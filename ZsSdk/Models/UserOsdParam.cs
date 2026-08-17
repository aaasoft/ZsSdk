using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 自定义OSD参数
/// </summary>
public class UserOsdParam
{
    /// <summary>
    /// 自定义OSD行数，取值０到３
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 是否显示，１：显示文本 ０：不显示文本
    /// </summary>
    [JsonPropertyName("display")]
    public int Display { get; set; }

    /// <summary>
    /// 文本颜色，取值０到３ ０：白色 １：红色 ２：蓝色 ３：绿色
    /// </summary>
    [JsonPropertyName("color")]
    public int Color { get; set; }

    /// <summary>
    /// 文本字体大小。取值０到３ ０：最小字号 ３：最大字号
    /// </summary>
    [JsonPropertyName("front_size")]
    public int FrontSize { get; set; }

    /// <summary>
    /// 想要显示的文本经过base64编码后的内容
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
