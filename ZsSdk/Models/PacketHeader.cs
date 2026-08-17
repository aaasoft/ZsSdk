using System.Text.Json.Serialization;
using ZsSdk.Enums;

namespace ZsSdk.Models;

/// <summary>
/// TCP数据包头
/// </summary>
public class PacketHeader
{
    /// <summary>
    /// 标识符1 (固定为 'V')
    /// </summary>
    [JsonIgnore]
    public byte Marker1 { get; set; } = (byte)'V';

    /// <summary>
    /// 标识符2 (固定为 'Z')
    /// </summary>
    [JsonIgnore]
    public byte Marker2 { get; set; } = (byte)'Z';

    /// <summary>
    /// 包类型 (0x00=数据包, 0x01=心跳包)
    /// </summary>
    [JsonIgnore]
    public PacketType PacketType { get; set; } = PacketType.Data;

    /// <summary>
    /// 包序号 (0-255循环)
    /// </summary>
    [JsonIgnore]
    public byte SequenceNumber { get; set; }

    /// <summary>
    /// 数据长度 (网络字节序)
    /// </summary>
    [JsonIgnore]
    public int DataLength { get; set; }

    /// <summary>
    /// 包头大小
    /// </summary>
    public const int HeaderSize = 8;
}
