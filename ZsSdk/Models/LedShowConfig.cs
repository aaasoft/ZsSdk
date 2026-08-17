using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LED显示配置
/// </summary>
public class LedShowConfig
{
    /// <summary>
    /// 使能屏显 (0:去使能, 1:使能)
    /// </summary>
    [JsonPropertyName("led_enable")]
    public int LedEnable { get; set; }

    /// <summary>
    /// LED显示内容
    /// </summary>
    [JsonPropertyName("led_content")]
    public LedContent? LedContent { get; set; }

    /// <summary>
    /// 语音播放播放模式
    /// </summary>
    [JsonPropertyName("voice_mode")]
    public int VoiceMode { get; set; }

    /// <summary>
    /// 语音内容
    /// </summary>
    [JsonPropertyName("voice_content")]
    public VoiceContent? VoiceContent { get; set; }

    /// <summary>
    /// 车辆信息
    /// </summary>
    [JsonPropertyName("car_info")]
    public CarInfo? CarInfo { get; set; }
}
