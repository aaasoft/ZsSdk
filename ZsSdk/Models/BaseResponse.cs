using System.Text.Json.Serialization;

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
    public string? Cmd { get; set; }

    /// <summary>
    /// 序列字符串（唯一），等于请求时的id
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 状态码
    /// </summary>
    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 状态码是否代表成功
    /// </summary>
    public bool IsSuccessStatusCode => StateCode == 200;

    /// <summary>
    /// 错误信息
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}
