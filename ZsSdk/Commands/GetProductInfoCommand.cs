using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备版本信息请求
/// </summary>
public class GetProductInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_product_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取设备版本信息响应
/// </summary>
public class GetProductInfoResponse
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
    public ProductInfo? Body { get; set; }
}
