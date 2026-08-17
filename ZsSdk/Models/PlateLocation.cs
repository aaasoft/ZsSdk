using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 车牌位置信息
/// </summary>
public class PlateLocation
{
    /// <summary>
    /// 矩形区域
    /// </summary>
    [JsonPropertyName("RECT")]
    public Rect? Rect { get; set; }
}
