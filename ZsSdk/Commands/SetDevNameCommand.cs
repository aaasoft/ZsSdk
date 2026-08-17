using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置设备名称请求
/// </summary>
public class SetDevNameRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_dev_name";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetDevNameBody? Body { get; set; }
}

/// <summary>
/// 设置设备名称请求体
/// </summary>
public class SetDevNameBody
{
    /// <summary>
    /// 设置设备名称。大小限制：最大60个字节
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 设置设备名称响应
/// </summary>
public class SetDevNameResponse
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
