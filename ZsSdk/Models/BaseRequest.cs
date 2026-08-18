using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 基础请求消息
/// </summary>
public class BaseRequest
{
    private static int _sequence;

    /// <summary>
    /// 命令字符串
    /// </summary>
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = string.Empty;

    /// <summary>
    /// 序列字符串（唯一），自动生成，10位数字字符串
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = GenerateId();

    /// <summary>
    /// 生成唯一ID（0到Int32.MaxValue自增，格式化为10位字符串）
    /// </summary>
    private static string GenerateId()
    {
        int value = Interlocked.Increment(ref _sequence);
        return value.ToString("D10");
    }
}
