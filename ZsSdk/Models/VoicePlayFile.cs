using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 播放路径音频文件信息
/// </summary>
public class VoicePlayFile
{
    /// <summary>
    /// 带有绝对路径的语音信息，utf-8/GBK编码的BASE64编码字符串
    /// </summary>
    [JsonPropertyName("file_path")]
    public string? FilePath { get; set; }
}
