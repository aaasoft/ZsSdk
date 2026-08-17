using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 请求开始登录
/// </summary>
public class StartLoginRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "start_login";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 请求开始登录响应
/// </summary>
public class StartLoginResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

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
public class LoginAuthenticationRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "login_authentication";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 用户密码；使用HMAC-SHA1算法对用户密码进行加密，加密物料使用signature，再对加密后的数据进行Base64生成的字符串
    /// </summary>
    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }
}

/// <summary>
/// 登录认证响应
/// </summary>
public class LoginAuthenticationResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
