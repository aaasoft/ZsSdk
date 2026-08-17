using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 白名单记录
/// </summary>
public class WhiteListRecord
{
    /// <summary>
    /// 白名单创建时间
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// 白名单生效时间
    /// </summary>
    [JsonPropertyName("enable_time")]
    public string? EnableTime { get; set; }

    /// <summary>
    /// 白名单失效时间
    /// </summary>
    [JsonPropertyName("overdue_time")]
    public string? OverdueTime { get; set; }

    /// <summary>
    /// 是否启动这条规则
    /// </summary>
    [JsonPropertyName("enable")]
    public int Enable { get; set; }

    /// <summary>
    /// 车牌号
    /// </summary>
    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    /// <summary>
    /// 是否启用时间段
    /// </summary>
    [JsonPropertyName("time_seg_enable")]
    public int TimeSegEnable { get; set; }

    /// <summary>
    /// 时间段
    /// </summary>
    [JsonPropertyName("seg_time")]
    public string? SegTime { get; set; }

    /// <summary>
    /// 是否需要报警
    /// </summary>
    [JsonPropertyName("need_alarm")]
    public int NeedAlarm { get; set; }

    /// <summary>
    /// 用户自定义代码
    /// </summary>
    [JsonPropertyName("vehicle_code")]
    public string? VehicleCode { get; set; }

    /// <summary>
    /// 用户自定义的注释
    /// </summary>
    [JsonPropertyName("vehicle_comment")]
    public string? VehicleComment { get; set; }

    /// <summary>
    /// 用户自己定义ID
    /// </summary>
    [JsonPropertyName("customer_id")]
    public int CustomerId { get; set; }

    /// <summary>
    /// 数据库中的id
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }
}
