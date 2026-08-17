using System.Text.Json.Serialization;
using ZsSdk.Enums;

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
    /// 序列字符串（唯一），字符串长度小于30
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
