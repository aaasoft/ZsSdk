using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 网络参数
/// </summary>
public class NetworkParam
{
    /// <summary>
    /// Ip地址
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>
    /// 子网掩码
    /// </summary>
    [JsonPropertyName("netmask")]
    public string? Netmask { get; set; }

    /// <summary>
    /// 网关
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>
    /// Dns服务器
    /// </summary>
    [JsonPropertyName("dns")]
    public string? Dns { get; set; }

    /// <summary>
    /// 网口号0|1
    /// </summary>
    [JsonPropertyName("source")]
    public int? Source { get; set; }

    /// <summary>
    /// DHCP使能
    /// </summary>
    [JsonPropertyName("dhcp_enable")]
    public int? DhcpEnable { get; set; }
}
