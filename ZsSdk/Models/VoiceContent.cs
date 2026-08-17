using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 语音内容
/// </summary>
public class VoiceContent
{
    /// <summary>
    /// 音量大小（0-9）
    /// </summary>
    [JsonPropertyName("voice_volume")]
    public int VoiceVolume { get; set; }

    /// <summary>
    /// 欢迎语
    /// </summary>
    [JsonPropertyName("voice_welcom")]
    public int VoiceWelcome { get; set; }

    /// <summary>
    /// 结束语
    /// </summary>
    [JsonPropertyName("voice_tag")]
    public int VoiceTag { get; set; }

    /// <summary>
    /// 用户自定义播放（utf-8的字符串经过64位编码之后的内容）
    /// </summary>
    [JsonPropertyName("play_content")]
    public string? PlayContent { get; set; }
}
