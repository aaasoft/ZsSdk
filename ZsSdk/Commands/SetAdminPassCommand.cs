using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 修改设备admin密码请求
/// </summary>
public class SetAdminPassRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_adminpass";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetAdminPassBody? Body { get; set; }
}

/// <summary>
/// 修改设备admin密码请求体
/// </summary>
public class SetAdminPassBody
{
    /// <summary>
    /// 经过64位编码后的Admin旧密码
    /// </summary>
    [JsonPropertyName("old_pass")]
    public string? OldPass { get; set; }

    /// <summary>
    /// 经过64位编码后的Admin新密码
    /// </summary>
    [JsonPropertyName("new_pass")]
    public string? NewPass { get; set; }
}

/// <summary>
/// 修改设备admin密码响应
/// </summary>
public class SetAdminPassResponse
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
