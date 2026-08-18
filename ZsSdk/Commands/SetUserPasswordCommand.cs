using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 修改账号密码请求
/// </summary>
public class SetUserPasswordRequest : BaseRequest
{
    public SetUserPasswordRequest()
    {
        Cmd = "set_user_password";
    }

    [JsonPropertyName("body")]
    public SetUserPasswordBody? Body { get; set; }
}

/// <summary>
/// 修改账号密码请求体
/// </summary>
public class SetUserPasswordBody
{
    /// <summary>
    /// 账号：admin 目前只支持admin账号修改密码
    /// </summary>
    [JsonPropertyName("account_number")]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// 旧密码数字和可见字符组成 base64编码
    /// </summary>
    [JsonPropertyName("old_password")]
    public string? OldPassword { get; set; }

    /// <summary>
    /// 新的密码数字和可见字符组成 base64编码
    /// </summary>
    [JsonPropertyName("new_password")]
    public string? NewPassword { get; set; }
}

/// <summary>
/// 修改账号密码响应
/// </summary>
public class SetUserPasswordResponse : BaseResponse
{
}
