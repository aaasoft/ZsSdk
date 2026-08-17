using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 出口记录
/// </summary>
public class OutputRecord
{
    /// <summary>
    /// 入口ip地址
    /// </summary>
    [JsonPropertyName("enter_ip")]
    public string? EnterIp { get; set; }

    /// <summary>
    /// 入口设备名称
    /// </summary>
    [JsonPropertyName("enter_name")]
    public string? EnterName { get; set; }

    /// <summary>
    /// 入口识别时间点
    /// </summary>
    [JsonPropertyName("enter_time")]
    public long EnterTime { get; set; }

    /// <summary>
    /// 出口ip地址
    /// </summary>
    [JsonPropertyName("leave_ip")]
    public string? LeaveIp { get; set; }

    /// <summary>
    /// 出口设备名称
    /// </summary>
    [JsonPropertyName("leave_name")]
    public string? LeaveName { get; set; }

    /// <summary>
    /// 出口识别时间点
    /// </summary>
    [JsonPropertyName("leave_time")]
    public long LeaveTime { get; set; }

    /// <summary>
    /// 车牌号码（汉字为GB2312编码）
    /// </summary>
    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("state")]
    public int State { get; set; }
}
