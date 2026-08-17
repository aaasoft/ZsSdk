using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 车辆品牌信息
/// </summary>
public class CarBrand
{
    /// <summary>
    /// 车辆品牌
    /// </summary>
    [JsonPropertyName("brand")]
    public int Brand { get; set; }

    /// <summary>
    /// 车辆类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 年份
    /// </summary>
    [JsonPropertyName("year")]
    public int Year { get; set; }
}
