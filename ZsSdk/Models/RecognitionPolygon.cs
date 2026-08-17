using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 识别区域多边形
/// </summary>
public class RecognitionPolygon
{
    /// <summary>
    /// 规则ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>
    /// 顶点个数
    /// </summary>
    [JsonPropertyName("point_num")]
    public int PointNum { get; set; }

    /// <summary>
    /// 顶点坐标
    /// </summary>
    [JsonPropertyName("point")]
    public List<Point>? Points { get; set; }
}
