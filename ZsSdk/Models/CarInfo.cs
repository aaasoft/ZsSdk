using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 车辆信息
/// </summary>
public class CarInfo
{
    /// <summary>
    /// 停车时间（分钟）
    /// </summary>
    [JsonPropertyName("park_time")]
    public int ParkTime { get; set; }

    /// <summary>
    /// 收费金额，元
    /// </summary>
    [JsonPropertyName("payment_amount")]
    public int PaymentAmount { get; set; }

    /// <summary>
    /// 车辆类型
    /// </summary>
    [JsonPropertyName("car_type")]
    public int CarType { get; set; }

    /// <summary>
    /// 车牌号：UTF-8经过64位编码
    /// </summary>
    [JsonPropertyName("car_plate")]
    public string? CarPlate { get; set; }
}
