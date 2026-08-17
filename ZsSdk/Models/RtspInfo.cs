using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// RTSP代理信息
/// </summary>
public class RtspInfo
{
    /// <summary>
    /// 转发代理伴侣机主码流地址
    /// </summary>
    [JsonPropertyName("proxyurl")]
    public string? ProxyUrl { get; set; }

    /// <summary>
    /// 转发代理伴侣机子码流地址
    /// </summary>
    [JsonPropertyName("proxyurl_sub1")]
    public string? ProxyUrlSub1 { get; set; }
}
