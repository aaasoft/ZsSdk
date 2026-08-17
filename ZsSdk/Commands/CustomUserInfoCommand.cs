using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取自定义信息请求
/// </summary>
public class GetCustomUserInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_custom_user_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取自定义信息响应
/// </summary>
public class GetCustomUserInfoResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; set; }

    [JsonPropertyName("body")]
    public CustomUserInfo? Body { get; set; }
}

/// <summary>
/// 设置用户自定义信息请求
/// </summary>
public class SetCustomUserInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_custom_user_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public CustomUserInfo? Body { get; set; }
}

/// <summary>
/// 设置用户自定义信息响应
/// </summary>
public class SetCustomUserInfoResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
