using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取加密方式请求
/// </summary>
public class GetEmsRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_ems";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取加密方式响应
/// </summary>
public class GetEmsResponse
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
    /// 加密方式列表
    /// </summary>
    [JsonPropertyName("ems")]
    public List<EncryptMethod>? Ems { get; set; }

    /// <summary>
    /// 一个十六位的字符串（用于对传输的密码进行加密）
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary>
/// 获取用户密码请求
/// </summary>
public class GetEncryptKeyRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_encrypt_key";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 主密钥字串（加密之后的密码）
    /// </summary>
    [JsonPropertyName("prime_key")]
    public string? PrimeKey { get; set; }
}

/// <summary>
/// 获取用户密码响应
/// </summary>
public class GetEncryptKeyResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// 加密后的用户密码
    /// </summary>
    [JsonPropertyName("encrypt_key")]
    public string? EncryptKey { get; set; }
}

/// <summary>
/// 重新设置用户密码请求
/// </summary>
public class ResetEncryptKeyRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "reset_encrypt_key";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 新设置的用户密码（加密之后的密码）
    /// </summary>
    [JsonPropertyName("new_encrypt_key")]
    public string? NewEncryptKey { get; set; }

    /// <summary>
    /// 主密钥字串（加密之后的密码）
    /// </summary>
    [JsonPropertyName("prime_key")]
    public string? PrimeKey { get; set; }
}

/// <summary>
/// 重新设置用户密码响应
/// </summary>
public class ResetEncryptKeyResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary>
/// 修改用户密码请求
/// </summary>
public class ChangeEncryptKeyRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "change_encrypt_key";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 旧的用户密码（加密后的）
    /// </summary>
    [JsonPropertyName("encrypt_key")]
    public string? EncryptKey { get; set; }

    /// <summary>
    /// 新设置的用户密码（加密之后的密码）
    /// </summary>
    [JsonPropertyName("new_encrypt_key")]
    public string? NewEncryptKey { get; set; }
}

/// <summary>
/// 修改用户密码响应
/// </summary>
public class ChangeEncryptKeyResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}

/// <summary>
/// 开启是否加密请求
/// </summary>
public class EnableEncryptRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "enable_encrypt";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 用户密码（加密后的）
    /// </summary>
    [JsonPropertyName("encrypt_key")]
    public string? EncryptKey { get; set; }

    /// <summary>
    /// 加密方式的索引（m_id:0为不加密）
    /// </summary>
    [JsonPropertyName("m_id")]
    public int MId { get; set; }
}

/// <summary>
/// 开启是否加密响应
/// </summary>
public class EnableEncryptResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}
