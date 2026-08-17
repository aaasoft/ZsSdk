using System.Text.Json.Serialization;
using ZsSdk.Enums;

namespace ZsSdk.Models;

/// <summary>
/// 基础响应消息
/// </summary>
public class BaseResponse
{
    /// <summary>
    /// 命令字符串
    /// </summary>
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = string.Empty;

    /// <summary>
    /// 序列字符串（唯一），字符串长度小于30，等于请求时的id
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 状态码
    /// </summary>
    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}
