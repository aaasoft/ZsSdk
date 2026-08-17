using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置网络参数请求
/// </summary>
public class SetNetworkParamRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_networkparam";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public NetworkParam? Body { get; set; }
}

/// <summary>
/// 设置网络参数响应
/// </summary>
public class SetNetworkParamResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}

/// <summary>
/// 获取网络参数请求
/// </summary>
public class GetNetworkParamRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_networkparam";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 网口号0|1
    /// </summary>
    [JsonPropertyName("source")]
    public int? Source { get; set; }
}

/// <summary>
/// 获取网络参数响应
/// </summary>
public class GetNetworkParamResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("body")]
    public NetworkParam? Body { get; set; }
}
