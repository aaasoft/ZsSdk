using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LCD背光时间控制
/// </summary>
public class LcdBrightTimeCtrl
{
    /// <summary>
    /// 一段时间的起始时间 时：分：秒 格式
    /// </summary>
    [JsonPropertyName("time_begin")]
    public string? TimeBegin { get; set; }

    /// <summary>
    /// 一段时间的结束时间 时：分：秒 格式
    /// </summary>
    [JsonPropertyName("time_end")]
    public string? TimeEnd { get; set; }

    /// <summary>
    /// Lcd背光亮度等级 0：不亮 1|2|3|4|5对应背光档数
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }
}
