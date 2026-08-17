using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 设备信息
/// </summary>
public class DeviceInfo
{
    /// <summary>
    /// 伴侣机Ip地址
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>
    /// 伴侣机设备名
    /// </summary>
    [JsonPropertyName("dev_name")]
    public string? DevName { get; set; }

    /// <summary>
    /// 伴侣机序列号
    /// </summary>
    [JsonPropertyName("sn")]
    public string? Sn { get; set; }

    /// <summary>
    /// 伴侣机设备类型
    /// </summary>
    [JsonPropertyName("device_type")]
    public string? DeviceType { get; set; }

    /// <summary>
    /// 伴侣机是否在线 0 离线 1在线
    /// </summary>
    [JsonPropertyName("online")]
    public int Online { get; set; }
}
