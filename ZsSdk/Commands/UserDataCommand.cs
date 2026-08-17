using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置用户私有数据请求
/// </summary>
public class SetUserDataRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_user_data";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetUserDataBody? Body { get; set; }
}

/// <summary>
/// 设置用户私有数据请求体
/// </summary>
public class SetUserDataBody
{
    /// <summary>
    /// 需要设置的用户数据，经过base64位编码
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary>
/// 设置用户私有数据响应
/// </summary>
public class SetUserDataResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 获取用户私有数据请求
/// </summary>
public class GetUserDataRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_user_data";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取用户私有数据响应
/// </summary>
public class GetUserDataResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public SetUserDataBody? Body { get; set; }
}
