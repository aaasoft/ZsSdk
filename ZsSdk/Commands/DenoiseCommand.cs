using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取降噪参数请求
/// </summary>
public class GetDenoiseRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_denoise";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取降噪参数响应
/// </summary>
public class GetDenoiseResponse
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
    public DenoiseParam? Body { get; set; }
}

/// <summary>
/// 设置降噪参数请求
/// </summary>
public class SetDenoiseRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_denoise";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public DenoiseParam? Body { get; set; }
}

/// <summary>
/// 设置降噪参数响应
/// </summary>
public class SetDenoiseResponse
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
