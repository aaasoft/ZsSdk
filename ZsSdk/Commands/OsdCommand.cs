using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置用户自定义OSD请求
/// </summary>
public class SetOsdParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_osd_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetOsdParaBody? Body { get; set; }
}

/// <summary>
/// 设置用户自定义OSD请求体
/// </summary>
public class SetOsdParaBody
{
    /// <summary>
    /// 固定值，必须设置为1
    /// </summary>
    [JsonPropertyName("osd_type")]
    public int OsdType { get; set; } = 1;

    [JsonPropertyName("user_osd")]
    public UserOsdConfig? UserOsd { get; set; }
}

/// <summary>
/// 设置用户自定义OSD响应
/// </summary>
public class SetOsdParaResponse
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
