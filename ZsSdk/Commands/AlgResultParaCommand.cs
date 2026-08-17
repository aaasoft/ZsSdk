using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取算法识别参数请求
/// </summary>
public class GetAlgResultParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_alg_result_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取算法识别参数响应
/// </summary>
public class GetAlgResultParaResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public AlgResultParam? Body { get; set; }
}

/// <summary>
/// 设置算法识别参数请求
/// </summary>
public class SetAlgResultParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_alg_result_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public AlgResultParam? Body { get; set; }
}

/// <summary>
/// 设置算法识别参数响应
/// </summary>
public class SetAlgResultParaResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
