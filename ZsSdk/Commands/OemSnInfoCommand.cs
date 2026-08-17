using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置客户定制SN序列号请求
/// </summary>
public class SetOemSnInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_oem_sn_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetOemSnInfoBody? Body { get; set; }
}

/// <summary>
/// 设置客户定制SN序列号请求体
/// </summary>
public class SetOemSnInfoBody
{
    /// <summary>
    /// 客户定制的序列号
    /// </summary>
    [JsonPropertyName("oem_sn")]
    public string? OemSn { get; set; }
}

/// <summary>
/// 设置客户定制SN序列号响应
/// </summary>
public class SetOemSnInfoResponse
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
/// 获取客户定制SN序列号请求
/// </summary>
public class GetOemSnInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_oem_sn_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取客户定制SN序列号响应
/// </summary>
public class GetOemSnInfoResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public SetOemSnInfoBody? Body { get; set; }
}
