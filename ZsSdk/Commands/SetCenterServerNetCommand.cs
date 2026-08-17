using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置中心服务器网络参数请求
/// </summary>
public class SetCenterServerNetRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_centerserver_net";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public CenterServerParam? Body { get; set; }
}

/// <summary>
/// 设置中心服务器网络参数响应
/// </summary>
public class SetCenterServerNetResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
