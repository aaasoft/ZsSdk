using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 时间戳信息
/// </summary>
public class TimeStamp
{
    /// <summary>
    /// 时间值
    /// </summary>
    [JsonPropertyName("Timeval")]
    public Timeval? Timeval { get; set; }
}
