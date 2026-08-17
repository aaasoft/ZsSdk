using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 入口记录
/// </summary>
public class InputRecord
{
    /// <summary>
    /// ip地址
    /// </summary>
    [JsonPropertyName("enter_ip")]
    public string? EnterIp { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    [JsonPropertyName("enter_name")]
    public string? EnterName { get; set; }

    /// <summary>
    /// 识别时间点
    /// </summary>
    [JsonPropertyName("enter_time")]
    public long EnterTime { get; set; }

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
