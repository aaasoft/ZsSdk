using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 屏显行内容
/// </summary>
public class LineContent
{
    /// <summary>
    /// 屏显显示模式
    /// </summary>
    [JsonPropertyName("show_mode")]
    public int ShowMode { get; set; }

    /// <summary>
    /// 用户自定义显示（utf-8的字符串经过64位编码之后的内容）
    /// </summary>
    [JsonPropertyName("show_content")]
    public string? ShowContent { get; set; }
}
