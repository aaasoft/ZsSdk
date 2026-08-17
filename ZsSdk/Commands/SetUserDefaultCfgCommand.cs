using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置当前配置为用户默认配置请求
/// </summary>
public class SetUserDefaultCfgRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_user_default_cfg";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 设置当前配置为用户默认配置响应
/// </summary>
public class SetUserDefaultCfgResponse
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
