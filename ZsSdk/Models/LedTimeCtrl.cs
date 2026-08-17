using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LED时间段控制
/// </summary>
public class LedTimeCtrl
{
    /// <summary>
    /// 时间段ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// LED等级[0,5]
    /// </summary>
    [JsonPropertyName("led_level")]
    public int LedLevel { get; set; }

    /// <summary>
    /// 时间段起始时间
    /// </summary>
    [JsonPropertyName("time_begin")]
    public string? TimeBegin { get; set; }

    /// <summary>
    /// 时间段结束时间
    /// </summary>
    [JsonPropertyName("time_end")]
    public string? TimeEnd { get; set; }

    /// <summary>
    /// 时间段使能（0去使能 1使能）
    /// </summary>
    [JsonPropertyName("timectrl_enable")]
    public bool TimeCtrlEnable { get; set; }
}
