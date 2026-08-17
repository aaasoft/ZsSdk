using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 组网内设备配置信息
/// </summary>
public class GroupDeviceConfig
{
    /// <summary>
    /// 连接状态
    /// </summary>
    [JsonPropertyName("connect_status")]
    public int ConnectStatus { get; set; }

    /// <summary>
    /// 开启组网功能
    /// </summary>
    [JsonPropertyName("enable_group")]
    public bool EnableGroup { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    [JsonPropertyName("ip_addr")]
    public string? IpAddr { get; set; }

    /// <summary>
    /// 设备的名称
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
