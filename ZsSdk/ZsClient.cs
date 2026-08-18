using System.Buffers.Binary;
using System.Collections.Concurrent;
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
    private readonly ZsClientOptions _options;
    private byte _sequenceNumber;
    private bool _disposed;
    private CancellationTokenSource? _receiveCts;
    private Task? _receiveTask;
    private Timer? _heartbeatTimer;

    /// <summary>
    /// 待响应的请求字典，key为请求ID
    /// </summary>
    private readonly ConcurrentDictionary<string, TaskCompletionSource<string>> _pendingRequests = new();

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
    /// 连接断开时触发
    /// </summary>
    public event EventHandler<Exception>? OnDisconnected;

    /// <summary>
    /// 初始化客户端
    /// </summary>
    /// <param name="options">客户端配置选项</param>
    public ZsClient(ZsClientOptions options)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        if (string.IsNullOrEmpty(options.Host))
            throw new ArgumentException("设备IP地址不能为空", nameof(options));
    }

    /// <summary>
    /// 初始化客户端（简化构造函数）
    /// </summary>
    /// <param name="host">设备IP地址</param>
    /// <param name="port">端口号，默认8131</param>
    public ZsClient(string host, int port = 8131) : this(new ZsClientOptions { Host = host, Port = port })
    {
    }

    /// <summary>
    /// 连接到设备并启动后台接收循环
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    public async Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        _tcpClient = new TcpClient();

        // 设置连接超时
        using var timeoutCts = new CancellationTokenSource(_options.ConnectionTimeoutMs);
        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(timeoutCts.Token, cancellationToken);

        try
        {
            await _tcpClient.ConnectAsync(_options.Host, _options.Port, linkedCts.Token);
        }
        catch (OperationCanceledException) when (timeoutCts.IsCancellationRequested)
        {
            throw new TimeoutException($"连接超时（{_options.ConnectionTimeoutMs}ms）");
        }

        _stream = _tcpClient.GetStream();

        // 设置读写超时为传输超时
        _stream.ReadTimeout = _options.TransportTimeoutMs;
        _stream.WriteTimeout = _options.TransportTimeoutMs;

        // 启动后台接收循环
        _receiveCts = new CancellationTokenSource();
        _receiveTask = Task.Run(() => ReceiveLoopAsync(_receiveCts.Token));

        // 启动心跳定时器（间隔为传输超时的1/3）
        var heartbeatInterval = TimeSpan.FromMilliseconds(_options.HeartbeatIntervalMs);
        _heartbeatTimer = new Timer(async _ =>
        {
            try
            {
                await SendHeartbeatAsync();
            }
            catch
            {
                // 心跳发送失败，由接收循环触发断开事件
            }
        }, null, heartbeatInterval, heartbeatInterval);
    }

    /// <summary>
    /// 断开连接
    /// </summary>
    public void Disconnect()
    {
        // 停止心跳定时器
        _heartbeatTimer?.Dispose();
        _heartbeatTimer = null;

        _receiveCts?.Cancel();
        _receiveCts?.Dispose();
        _receiveCts = null;

        _stream?.Close();
        _tcpClient?.Close();
        _stream = null;
        _tcpClient = null;

        // 取消所有待响应的请求
        foreach (var kvp in _pendingRequests)
        {
            kvp.Value.TrySetCanceled();
        }
        _pendingRequests.Clear();
    }

    /// <summary>
    /// 发送请求（不等待响应）
    /// </summary>
    /// <typeparam name="TRequest">请求类型</typeparam>
    /// <param name="request">请求对象</param>
    /// <param name="cancellationToken">取消令牌</param>
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
    /// 发送请求并等待响应（通过请求ID匹配响应）
    /// </summary>
    /// <typeparam name="TRequest">请求类型</typeparam>
    /// <typeparam name="TResponse">响应类型</typeparam>
    /// <param name="request">请求对象</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>响应对象</returns>
    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
    {
        // 从请求对象中提取ID（必须继承自BaseRequest）
        if (request is not BaseRequest baseRequest)
            throw new InvalidOperationException("请求对象必须继承自BaseRequest");

        string requestId = baseRequest.Id;

        // 注册待响应的请求
        var tcs = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
        _pendingRequests[requestId] = tcs;

        try
        {
            // 发送请求
            await SendRequestAsync(request, cancellationToken);

            // 等待响应（使用传输超时）
            using var timeoutCts = new CancellationTokenSource(_options.TransportTimeoutMs);
            using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(timeoutCts.Token, cancellationToken);

            // 注册取消回调
            await using var registration = linkedCts.Token.Register(() => tcs.TrySetCanceled());

            string responseJson;
            try
            {
                responseJson = await tcs.Task;
            }
            catch (OperationCanceledException) when (timeoutCts.IsCancellationRequested)
            {
                throw new TimeoutException($"等待响应超时（{_options.TransportTimeoutMs}ms）");
            }

            // 反序列化响应
            TResponse? response;
            try
            {
                response = JsonSerializer.Deserialize<TResponse>(responseJson, JsonOptions);
                if (response == null)
                    throw new InvalidOperationException("响应反序列化失败");
            }
            catch (Exception ex) when (ex is not InvalidOperationException)
            {
                throw new IOException($"将JSON序列化为[{typeof(TResponse).FullName}]时出错，JSON内容：{responseJson}");
            }
            return response;
        }
        finally
        {
            _pendingRequests.TryRemove(requestId, out _);
        }
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
    /// 后台接收循环（自动在连接后启动）
    /// </summary>
    private async Task ReceiveLoopAsync(CancellationToken cancellationToken)
    {
        Exception? lastException = null;
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
            catch (Exception ex)
            {
                lastException = ex;
                // 连接断开时退出循环
                if (_stream == null || cancellationToken.IsCancellationRequested)
                    break;
                OnDisconnected?.Invoke(this, lastException);
                Dispose();
                return;
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

        // 检查是否有对应的待响应请求
        if (root.TryGetProperty("id", out var idElement))
        {
            string? id = idElement.GetString();
            if (!string.IsNullOrEmpty(id) && _pendingRequests.TryRemove(id, out var tcs))
            {
                // 找到匹配的请求，完成响应
                tcs.TrySetResult(json);
                return;
            }
        }

        // 没有匹配的请求，作为推送消息处理
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
