using System.Text.Json.Serialization;

namespace ZsSdk.Enums;

/// <summary>
/// 包类型
/// </summary>
public enum PacketType : byte
{
    /// <summary>
    /// 数据包
    /// </summary>
    Data = 0x00,

    /// <summary>
    /// 心跳包
    /// </summary>
    Heartbeat = 0x01
}
