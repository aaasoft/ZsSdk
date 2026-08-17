using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取识别区域参数请求
/// </summary>
public class GetRecoParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_reco_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取识别区域参数响应
/// </summary>
public class GetRecoParaResponse
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
    public RecoParaBody? Body { get; set; }
}

/// <summary>
/// 识别区域参数响应体
/// </summary>
public class RecoParaBody
{
    [JsonPropertyName("recognition_area")]
    public RecognitionAreaConfig? RecognitionArea { get; set; }
}

/// <summary>
/// 设置识别区域参数请求
/// </summary>
public class SetRecoParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_reco_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public RecoParaBody? Body { get; set; }
}

/// <summary>
/// 设置识别区域参数响应
/// </summary>
public class SetRecoParaResponse
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
