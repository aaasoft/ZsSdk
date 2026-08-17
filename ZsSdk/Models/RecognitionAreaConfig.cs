using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 识别区域配置
/// </summary>
public class RecognitionAreaConfig
{
    /// <summary>
    /// 规则数量
    /// </summary>
    [JsonPropertyName("polygon_num")]
    public int PolygonNum { get; set; }

    /// <summary>
    /// 多边形列表
    /// </summary>
    [JsonPropertyName("polygon")]
    public List<RecognitionPolygon>? Polygons { get; set; }
}
