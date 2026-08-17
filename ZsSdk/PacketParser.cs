using System.Buffers.Binary;
using System.Text;
using System.Text.Json;
using ZsSdk.Enums;
using ZsSdk.Models;

namespace ZsSdk;

/// <summary>
/// 数据包解析器
/// </summary>
public static class PacketParser
{
    private static readonly Encoding encoding = Encoding.GetEncoding("GB18030");
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// 创建数据包
    /// </summary>
    /// <param name="json">JSON数据</param>
    /// <param name="sequenceNumber">包序号</param>
    /// <returns>完整的数据包字节数组</returns>
    public static byte[] CreatePacket(string json, byte sequenceNumber = 0)
    {
        byte[] data = encoding.GetBytes(json);
        byte[] packet = new byte[PacketHeader.HeaderSize + data.Length];

        // 包头
        packet[0] = (byte)'V';
        packet[1] = (byte)'Z';
        packet[2] = (byte)PacketType.Data;
        packet[3] = sequenceNumber;

        // 数据长度（网络字节序，大端）
        BinaryPrimitives.WriteInt32BigEndian(packet.AsSpan(4), data.Length);

        // 数据
        Array.Copy(data, 0, packet, PacketHeader.HeaderSize, data.Length);

        return packet;
    }

    /// <summary>
    /// 创建心跳包
    /// </summary>
    /// <returns>心跳包字节数组</returns>
    public static byte[] CreateHeartbeatPacket()
    {
        byte[] packet = new byte[PacketHeader.HeaderSize];
        packet[0] = (byte)'V';
        packet[1] = (byte)'Z';
        packet[2] = (byte)PacketType.Heartbeat;
        packet[3] = 0;
        // 数据长度为0
        return packet;
    }

    /// <summary>
    /// 解析数据包头
    /// </summary>
    /// <param name="data">数据</param>
    /// <param name="header">解析后的包头</param>
    /// <returns>是否解析成功</returns>
    public static bool TryParseHeader(ReadOnlySpan<byte> data, out PacketHeader header)
    {
        header = new PacketHeader();

        if (data.Length < PacketHeader.HeaderSize)
            return false;

        if (data[0] != (byte)'V' || data[1] != (byte)'Z')
            return false;

        header.Marker1 = data[0];
        header.Marker2 = data[1];
        header.PacketType = (PacketType)data[2];
        header.SequenceNumber = data[3];
        header.DataLength = BinaryPrimitives.ReadInt32BigEndian(data.Slice(4, 4));

        return true;
    }

    /// <summary>
    /// 从数据包中提取JSON字符串
    /// </summary>
    /// <param name="packet">完整的数据包</param>
    /// <returns>JSON字符串</returns>
    public static string? ExtractJson(ReadOnlySpan<byte> packet,out ReadOnlySpan<byte> extraDataSpan)
    {
        extraDataSpan = ReadOnlySpan<byte>.Empty;
        if (!TryParseHeader(packet, out var header))
            return null;

        if (header.PacketType == PacketType.Heartbeat)
            return null;

        if (packet.Length < PacketHeader.HeaderSize + header.DataLength)
            return null;

        var dataSpan = packet.Slice(PacketHeader.HeaderSize, header.DataLength);
        extraDataSpan = packet.Slice(PacketHeader.HeaderSize + header.DataLength);

        var jsonEndIndex = dataSpan.IndexOf((byte)0);
        if (jsonEndIndex > 0)
        {
            dataSpan = dataSpan.Slice(0, jsonEndIndex);
            extraDataSpan = packet.Slice(PacketHeader.HeaderSize + jsonEndIndex + 1);
        }
        var json = encoding.GetString(dataSpan);
        return json;
    }

    /// <summary>
    /// 获取数据包的总长度
    /// </summary>
    /// <param name="data">已接收的数据</param>
    /// <returns>数据包总长度，如果数据不足返回-1</returns>
    public static int GetPacketLength(ReadOnlySpan<byte> data)
    {
        if (data.Length < PacketHeader.HeaderSize)
            return -1;

        int dataLength = BinaryPrimitives.ReadInt32BigEndian(data.Slice(4, 4));
        return PacketHeader.HeaderSize + dataLength;
    }

    /// <summary>
    /// 检查是否是心跳包
    /// </summary>
    /// <param name="data">数据</param>
    /// <returns>是否是心跳包</returns>
    public static bool IsHeartbeat(ReadOnlySpan<byte> data)
    {
        if (data.Length < 3)
            return false;

        return data[0] == (byte)'V' && data[1] == (byte)'Z' && data[2] == (byte)PacketType.Heartbeat;
    }
}
