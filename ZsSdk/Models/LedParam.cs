using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LED参数
/// </summary>
public class LedParam
{
    /// <summary>
    /// LED模式：0智能 1常亮 2常灭 3时间段
    /// </summary>
    [JsonPropertyName("led_mode")]
    public int LedMode { get; set; }

    /// <summary>
    /// LED等级[0,5]
    /// </summary>
    [JsonPropertyName("led_level")]
    public int LedLevel { get; set; }

    /// <summary>
    /// 时间段控制
    /// </summary>
    [JsonPropertyName("time_ctrl")]
    public List<LedTimeCtrl>? TimeCtrl { get; set; }
}
