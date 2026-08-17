using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 中心服务器参数
/// </summary>
public class CenterServerParam
{
    /// <summary>
    /// 中心服务器地址
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// 中心服务器端口
    /// </summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>
    /// 开启ssl连接
    /// </summary>
    [JsonPropertyName("enable_ssl")]
    public bool EnableSsl { get; set; }

    /// <summary>
    /// ssl端口
    /// </summary>
    [JsonPropertyName("ssl_port")]
    public int SslPort { get; set; }

    /// <summary>
    /// 超时时间
    /// </summary>
    [JsonPropertyName("http_timeout")]
    public int HttpTimeout { get; set; }
}
