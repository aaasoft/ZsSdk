using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 设备vzid信息
/// </summary>
public class VzId
{
    /// <summary>
    /// 开启组网功能
    /// </summary>
    [JsonPropertyName("enable_group")]
    public bool EnableGroup { get; set; }

    /// <summary>
    /// 设备ip
    /// </summary>
    [JsonPropertyName("ip_addr")]
    public string? IpAddr { get; set; }

    /// <summary>
    /// 设备名字
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设备序列号
    /// </summary>
    [JsonPropertyName("sn")]
    public string? Sn { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
