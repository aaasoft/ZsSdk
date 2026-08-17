using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 虚拟线圈参数
/// </summary>
public class VirtualLoop
{
    /// <summary>
    /// 线圈ID
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
