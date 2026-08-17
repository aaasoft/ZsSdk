using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 4G参数信息
/// </summary>
public class FourGParam
{
    /// <summary>
    /// 4G模块状态
    /// </summary>
    [JsonPropertyName("state_4g")]
    public bool State4G { get; set; }

    /// <summary>
    /// SIM卡槽状态
    /// </summary>
    [JsonPropertyName("state_sim")]
    public bool StateSim { get; set; }

    /// <summary>
    /// SIM卡信息
    /// </summary>
    [JsonPropertyName("sim_id")]
    public string? SimId { get; set; }

    /// <summary>
    /// 当前移动运营商
    /// </summary>
    [JsonPropertyName("net_cop")]
    public string? NetCop { get; set; }

    /// <summary>
    /// 移动网络信号强度
    /// </summary>
    [JsonPropertyName("rssi")]
    public int Rssi { get; set; }

    /// <summary>
    /// 移动网络注册信息
    /// </summary>
    [JsonPropertyName("net_creg")]
    public bool NetCreg { get; set; }

    /// <summary>
    /// 移动网络附着和分离
    /// </summary>
    [JsonPropertyName("net_cgatt")]
    public bool NetCgatt { get; set; }

    /// <summary>
    /// 当前分配到的IP地址
    /// </summary>
    [JsonPropertyName("IP")]
    public string? IP { get; set; }

    /// <summary>
    /// 是否使用APN接入点模式
    /// </summary>
    [JsonPropertyName("apn_enable")]
    public bool ApnEnable { get; set; }

    /// <summary>
    /// APN模式
    /// </summary>
    [JsonPropertyName("apn_mode")]
    public int ApnMode { get; set; }

    /// <summary>
    /// APN地址
    /// </summary>
    [JsonPropertyName("apn")]
    public string? Apn { get; set; }
}
