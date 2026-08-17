using System.Buffers.Binary;
using System.Net.Sockets;
using System.Text.Json;
using ZsSdk.Models;

namespace ZsSdk;

/// <summary>
/// 臻识科技车牌识别一体机TCP客户端
/// </summary>
public class ZsClient : IDisposable
{
    private TcpClient? _tcpClient;
    private NetworkStream? _stream;
    private readonly string _host;
    private readonly int _port;
    private byte _sequenceNumber;
    private bool _disposed;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// 接收到心跳消息时
    /// </summary>
    public event EventHandler? OnHeartbeat;

    /// <summary>
    /// 接收到识别结果时触发
    /// </summary>
    public event EventHandler<IvsResultMessage>? OnIvsResult;

    /// <summary>
    /// 接收到GPIO触发消息时触发
    /// </summary>
    public event EventHandler<Commands.GpioTriggerMessage>? OnGpioTrigger;

    /// <summary>
    /// 接收到脱机状态改变消息时触发
    /// </summary>
    public event EventHandler<Commands.OfflineStatusChangeMessage>? OnOfflineStatusChange;

    /// <summary>
    /// 接收到关闭连接消息时触发
    /// </summary>
    public event EventHandler<Commands.CloseSocketMessage>? OnCloseSocket;

    /// <summary>
    /// 接收到组网识别结果时触发
    /// </summary>
    public event EventHandler<Commands.DgPlateInfoResultMessage>? OnDgPlateInfoResult;

    /// <summary>
    /// 接收到通用报警结果时触发
    /// </summary>
    public event EventHandler<Commands.CommonAlarmResultMessage>? OnCommonAlarmResult;

    /// <summary>
    /// 接收到OpenSDK推送消息时触发
    /// </summary>
    public event EventHandler<Commands.OpenSdkPushMessage>? OnOpenSdkPushMessage;

    /// <summary>
    /// 初始化客户端
    /// </summary>
    /// <param name="host">设备IP地址</param>
    /// <param name="port">端口号，默认8131</param>
    public ZsClient(string host, int port = 8131)
    {
        _host = host;
        _port = port;
    }

    /// <summary>
    /// 连接到设备
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    public async Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        _tcpClient = new TcpClient();
        await _tcpClient.ConnectAsync(_host, _port, cancellationToken);
        _stream = _tcpClient.GetStream();
    }

    /// <summary>
    /// 断开连接
    /// </summary>
    public void Disconnect()
    {
        _stream?.Close();
        _tcpClient?.Close();
        _stream = null;
        _tcpClient = null;
    }

    /// <summary>
    /// 发送请求
    /// </summary>
    /// <typeparam name="TRequest">请求类型</typeparam>
    /// <param name="request">请求对象</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>响应对象</returns>
    public async Task SendRequestAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default)
    {
        if (_stream == null)
            throw new InvalidOperationException("未连接到设备");

        string requestJson = JsonSerializer.Serialize(request, JsonOptions);
        byte[] packet = PacketParser.CreatePacket(requestJson, GetNextSequenceNumber());

        await _stream.WriteAsync(packet, 0, packet.Length, cancellationToken);
        await _stream.FlushAsync(cancellationToken);
    }

    /// <summary>
    /// 发送请求并接收响应
    /// </summary>
    /// <typeparam name="TRequest">请求类型</typeparam>
    /// <typeparam name="TResponse">响应类型</typeparam>
    /// <param name="request">请求对象</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>响应对象</returns>
    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
    {
        await SendRequestAsync(request, cancellationToken);

        byte[] responsePacket = await ReadPacketAsync(cancellationToken);
        string? responseJson = PacketParser.ExtractJson(responsePacket, out _);

        if (string.IsNullOrEmpty(responseJson))
            throw new InvalidOperationException("无法解析响应数据");
        TResponse? response;
        try
        {
            response = JsonSerializer.Deserialize<TResponse>(responseJson, JsonOptions);
            if (response == null)
                throw new InvalidOperationException("响应反序列化失败");
        }
        catch
        {
            throw new IOException($"将JSON序列化为[{typeof(TResponse).FullName}]时出错，JSON内容：{responseJson}");
        }
        return response;
    }

    /// <summary>
    /// 发送心跳包
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    public async Task SendHeartbeatAsync(CancellationToken cancellationToken = default)
    {
        if (_stream == null)
            throw new InvalidOperationException("未连接到设备");

        byte[] heartbeat = PacketParser.CreateHeartbeatPacket();
        await _stream.WriteAsync(heartbeat, 0, heartbeat.Length, cancellationToken);
        await _stream.FlushAsync(cancellationToken);
    }

    /// <summary>
    /// 启动接收消息循环
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    public async Task StartReceiveLoopAsync(CancellationToken cancellationToken = default)
    {
        if (_stream == null)
            throw new InvalidOperationException("未连接到设备");

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                byte[] packet = await ReadPacketAsync(cancellationToken);

                if (PacketParser.IsHeartbeat(packet))
                {
                    OnHeartbeat?.Invoke(this, EventArgs.Empty);
                    continue;
                }

                string? json = PacketParser.ExtractJson(packet, out var extraDataSpan);
                if (string.IsNullOrEmpty(json))
                    continue;
                ProcessReceivedMessage(json, extraDataSpan);
            }
            catch (OperationCanceledException)
            {
                break;
            }
            catch
            {
                throw;
            }
        }
    }

    private void ProcessReceivedMessage(string json, ReadOnlySpan<byte> extraDataSpan)
    {
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        if (!root.TryGetProperty("cmd", out var cmdElement))
            return;

        string? cmd = cmdElement.GetString();
        if (string.IsNullOrEmpty(cmd))
            return;

        switch (cmd)
        {
            case "ivs_result":
                var ivsResult = JsonSerializer.Deserialize<IvsResultMessage>(json, JsonOptions);
                if (ivsResult != null)
                {
                    if (ivsResult.ClipImgSize > 0)
                    {
                        ivsResult.ClipImg = extraDataSpan.Slice(0, ivsResult.ClipImgSize).ToArray();
                        extraDataSpan = extraDataSpan.Slice(ivsResult.ClipImgSize);
                    }
                    if (ivsResult.FullImgSize > 0)
                    {
                        ivsResult.FullImg = extraDataSpan.Slice(0, ivsResult.FullImgSize).ToArray();
                        extraDataSpan = extraDataSpan.Slice(ivsResult.FullImgSize);
                    }
                    OnIvsResult?.Invoke(this, ivsResult);
                }
                break;

            case "gpio_trigger":
                var gpioTrigger = JsonSerializer.Deserialize<Commands.GpioTriggerMessage>(json, JsonOptions);
                if (gpioTrigger != null)
                    OnGpioTrigger?.Invoke(this, gpioTrigger);
                break;

            case "offline_status_change":
                var offlineStatus = JsonSerializer.Deserialize<Commands.OfflineStatusChangeMessage>(json, JsonOptions);
                if (offlineStatus != null)
                    OnOfflineStatusChange?.Invoke(this, offlineStatus);
                break;

            case "close_socket":
                var closeSocket = JsonSerializer.Deserialize<Commands.CloseSocketMessage>(json, JsonOptions);
                if (closeSocket != null)
                    OnCloseSocket?.Invoke(this, closeSocket);
                break;

            case "dg_plateinfo_result":
                var dgResult = JsonSerializer.Deserialize<Commands.DgPlateInfoResultMessage>(json, JsonOptions);
                if (dgResult != null)
                    OnDgPlateInfoResult?.Invoke(this, dgResult);
                break;

            case "common_alarm_result":
                var alarmResult = JsonSerializer.Deserialize<Commands.CommonAlarmResultMessage>(json, JsonOptions);
                if (alarmResult != null)
                    OnCommonAlarmResult?.Invoke(this, alarmResult);
                break;

            case "opensdk_push_message":
                var pushMsg = JsonSerializer.Deserialize<Commands.OpenSdkPushMessage>(json, JsonOptions);
                if (pushMsg != null)
                    OnOpenSdkPushMessage?.Invoke(this, pushMsg);
                break;
        }
    }

    private async Task<byte[]> ReadPacketAsync(CancellationToken cancellationToken)
    {
        if (_stream == null)
            throw new InvalidOperationException("未连接到设备");

        // 读取包头
        byte[] header = new byte[PacketHeader.HeaderSize];
        int bytesRead = 0;
        while (bytesRead < PacketHeader.HeaderSize)
        {
            int read = await _stream.ReadAsync(header, bytesRead, PacketHeader.HeaderSize - bytesRead, cancellationToken);
            if (read == 0)
                throw new InvalidOperationException("连接已关闭");
            bytesRead += read;
        }

        // 获取数据长度
        int dataLength = BinaryPrimitives.ReadInt32BigEndian(header.AsSpan(4));

        // 分配完整包内存
        byte[] packet = new byte[PacketHeader.HeaderSize + dataLength];
        Array.Copy(header, packet, PacketHeader.HeaderSize);

        // 读取数据
        bytesRead = 0;
        while (bytesRead < dataLength)
        {
            int read = await _stream.ReadAsync(packet, PacketHeader.HeaderSize + bytesRead, dataLength - bytesRead, cancellationToken);
            if (read == 0)
                throw new InvalidOperationException("连接已关闭");
            bytesRead += read;
        }

        return packet;
    }

    private byte GetNextSequenceNumber()
    {
        byte current = _sequenceNumber;
        _sequenceNumber = (byte)((_sequenceNumber + 1) % 256);
        return current;
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            Disconnect();
            _disposed = true;
        }
        GC.SuppressFinalize(this);
    }
}
