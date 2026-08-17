using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 坐标点
/// </summary>
public class Point
{
    /// <summary>
    /// 横向坐标，从左至右，从0递增
    /// </summary>
    [JsonPropertyName("x")]
    public int X { get; set; }

    /// <summary>
    /// 纵向坐标，从上至下，从0递增
    /// </summary>
    [JsonPropertyName("y")]
    public int Y { get; set; }
}
