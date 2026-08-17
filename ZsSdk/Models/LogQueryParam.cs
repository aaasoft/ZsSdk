using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 日志查询参数
/// </summary>
public class LogQueryParam
{
    /// <summary>
    /// 开始时间时间戳
    /// </summary>
    [JsonPropertyName("start_time")]
    public long StartTime { get; set; }

    /// <summary>
    /// 结束时间时间戳
    /// </summary>
    [JsonPropertyName("end_time")]
    public long EndTime { get; set; }

    /// <summary>
    /// 日志排序方式，默认1表示降序(0升序)
    /// </summary>
    [JsonPropertyName("qtype")]
    public int QType { get; set; }

    /// <summary>
    /// 最大的日志id
    /// </summary>
    [JsonPropertyName("max_id")]
    public long MaxId { get; set; }

    /// <summary>
    /// 最小的日志id
    /// </summary>
    [JsonPropertyName("min_id")]
    public long MinId { get; set; }

    /// <summary>
    /// 第一次默认设置为0，后面是应答包last_id的值
    /// </summary>
    [JsonPropertyName("start_id")]
    public long StartId { get; set; }
}
