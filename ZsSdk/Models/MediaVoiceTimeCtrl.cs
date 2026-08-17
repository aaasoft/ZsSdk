using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LCD时间音量控制
/// </summary>
public class MediaVoiceTimeCtrl
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
    /// 声音大小0：静音 1|2|3|4|5对应声音档数
    /// </summary>
    [JsonPropertyName("voice_level")]
    public int VoiceLevel { get; set; }
}
