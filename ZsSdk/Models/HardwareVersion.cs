using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 硬件版本信息
/// </summary>
public class HardwareVersion
{
    /// <summary>
    /// 硬件版本号
    /// </summary>
    [JsonPropertyName("board_version")]
    public long BoardVersion { get; set; }

    /// <summary>
    /// 扩展数据大小
    /// </summary>
    [JsonPropertyName("exdataSize")]
    public long ExdataSize { get; set; }
}
