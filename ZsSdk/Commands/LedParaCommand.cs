using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置LED参数请求
/// </summary>
public class SetLedParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_led_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public LedParam? Body { get; set; }
}

/// <summary>
/// 设置LED参数响应
/// </summary>
public class SetLedParaResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 获取LED参数请求
/// </summary>
public class GetLedParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_led_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取LED参数响应
/// </summary>
public class GetLedParaResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public LedParam? Body { get; set; }
}
