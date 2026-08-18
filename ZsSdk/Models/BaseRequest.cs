using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 基础请求消息
/// </summary>
public class BaseRequest
{
    /// <summary>
    /// 命令字符串
    /// </summary>
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = string.Empty;

    /// <summary>
    /// 序列字符串（唯一），自动生成，长度小于30
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = GenerateId();

    /// <summary>
    /// 生成唯一ID（8位随机字符串）
    /// </summary>
    private static string GenerateId()
    {
        return Guid.NewGuid().ToString("N")[..8];
    }
}
