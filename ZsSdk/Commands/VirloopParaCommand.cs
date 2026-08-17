using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取虚拟线圈参数请求
/// </summary>
public class GetVirloopParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_virloop_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取虚拟线圈参数响应
/// </summary>
public class GetVirloopParaResponse
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
    public VirloopParaBody? Body { get; set; }
}

/// <summary>
/// 虚拟线圈参数响应体
/// </summary>
public class VirloopParaBody
{
    [JsonPropertyName("virtualloop")]
    public VirtualLoopConfig? VirtualLoop { get; set; }
}

/// <summary>
/// 设置虚拟线圈参数请求
/// </summary>
public class SetVirloopParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_virloop_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public VirloopParaBody? Body { get; set; }
}

/// <summary>
/// 设置虚拟线圈参数响应
/// </summary>
public class SetVirloopParaResponse
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
