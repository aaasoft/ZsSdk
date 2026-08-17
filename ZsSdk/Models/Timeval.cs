using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 时间戳
/// </summary>
public class Timeval
{
    /// <summary>
    /// 秒
    /// </summary>
    [JsonPropertyName("sec")]
    public long Sec { get; set; }

    /// <summary>
    /// 微秒
    /// </summary>
    [JsonPropertyName("usec")]
    public long Usec { get; set; }
}
