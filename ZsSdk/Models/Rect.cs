using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 矩形区域
/// </summary>
public class Rect
{
    /// <summary>
    /// 左边界
    /// </summary>
    [JsonPropertyName("left")]
    public int Left { get; set; }

    /// <summary>
    /// 上边界
    /// </summary>
    [JsonPropertyName("top")]
    public int Top { get; set; }

    /// <summary>
    /// 右边界
    /// </summary>
    [JsonPropertyName("right")]
    public int Right { get; set; }

    /// <summary>
    /// 下边界
    /// </summary>
    [JsonPropertyName("bottom")]
    public int Bottom { get; set; }
}
