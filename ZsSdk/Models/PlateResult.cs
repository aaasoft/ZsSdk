using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 车牌识别结果
/// </summary>
public class PlateResult
{
    /// <summary>
    /// 车牌号码（汉字为GB2312编码）
    /// </summary>
    [JsonPropertyName("license")]
    public string? License { get; set; }

    /// <summary>
    /// 车牌是否加密（0不加密，1加密）
    /// </summary>
    [JsonPropertyName("enable_encrypt")]
    public int EnableEncrypt { get; set; }

    /// <summary>
    /// 车牌颜色序号
    /// </summary>
    [JsonPropertyName("colorType")]
    public int ColorType { get; set; }

    /// <summary>
    /// 车牌类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 车牌可信度
    /// </summary>
    [JsonPropertyName("confidence")]
    public int Confidence { get; set; }

    /// <summary>
    /// 亮度评价
    /// </summary>
    [JsonPropertyName("bright")]
    public int Bright { get; set; }

    /// <summary>
    /// 运动方向
    /// </summary>
    [JsonPropertyName("direction")]
    public int Direction { get; set; }

    /// <summary>
    /// 车牌位置
    /// </summary>
    [JsonPropertyName("location")]
    public PlateLocation? Location { get; set; }

    /// <summary>
    /// 识别所用时间
    /// </summary>
    [JsonPropertyName("timeUsed")]
    public int TimeUsed { get; set; }

    /// <summary>
    /// 车的亮度
    /// </summary>
    [JsonPropertyName("carBright")]
    public int CarBright { get; set; }

    /// <summary>
    /// 车的颜色
    /// </summary>
    [JsonPropertyName("carColor")]
    public int CarColor { get; set; }

    /// <summary>
    /// 识别时间点
    /// </summary>
    [JsonPropertyName("timeStamp")]
    public TimeStamp? TimeStamp { get; set; }

    /// <summary>
    /// 触发结果的类型
    /// </summary>
    [JsonPropertyName("triggerType")]
    public int TriggerType { get; set; }

    /// <summary>
    /// 车牌真实宽度
    /// </summary>
    [JsonPropertyName("plate_true_width")]
    public int PlateTrueWidth { get; set; }

    /// <summary>
    /// 车牌距离
    /// </summary>
    [JsonPropertyName("plate_distance")]
    public int PlateDistance { get; set; }

    /// <summary>
    /// 是否是伪车牌
    /// </summary>
    [JsonPropertyName("fake_plate")]
    public int FakePlate { get; set; }

    /// <summary>
    /// 车辆位置
    /// </summary>
    [JsonPropertyName("car_location")]
    public PlateLocation? CarLocation { get; set; }

    /// <summary>
    /// 车辆品牌信息
    /// </summary>
    [JsonPropertyName("car_brand")]
    public CarBrand? CarBrand { get; set; }

    /// <summary>
    /// 特征码(16位字符串)
    /// </summary>
    [JsonPropertyName("featureCode")]
    public string? FeatureCode { get; set; }
}
