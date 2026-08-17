using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 语音文件信息
/// </summary>
public class VoiceFileInfo
{
    /// <summary>
    /// 语音文件名称，base64字符串
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }
}
