using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 请求开始登录
/// </summary>
public class StartLoginRequest : BaseRequest
{
    public StartLoginRequest()
    {
        Cmd = "start_login";
    }
}

/// <summary>
/// 请求开始登录响应
/// </summary>
public class StartLoginResponse : BaseResponse
{
    /// <summary>
    /// 当前加密方式的索引
    /// </summary>
    [JsonPropertyName("active_id")]
    public int ActiveId { get; set; }

    /// <summary>
    /// 设备序列号
    /// </summary>
    [JsonPropertyName("device_sn")]
    public string? DeviceSn { get; set; }

    /// <summary>
    /// 加密方式列表
    /// </summary>
    [JsonPropertyName("ems")]
    public List<LoginEncryptMethod>? Ems { get; set; }

    /// <summary>
    /// 一个十六位的字符串（用于对传输的密码进行加密）
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary>
/// 登录加密方式
/// </summary>
public class LoginEncryptMethod
{
    [JsonPropertyName("m_id")]
    public int MId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 登录认证请求
/// </summary>
public class LoginAuthenticationRequest : BaseRequest
{
    public LoginAuthenticationRequest()
    {
        Cmd = "login_authentication";
    }

    /// <summary>
    /// 用户密码；使用HMAC-SHA1算法对用户密码进行加密，加密物料使用signature，再对加密后的数据进行Base64生成的字符串
    /// </summary>
    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }
}

/// <summary>
/// 登录认证响应
/// </summary>
public class LoginAuthenticationResponse : BaseResponse
{
}
