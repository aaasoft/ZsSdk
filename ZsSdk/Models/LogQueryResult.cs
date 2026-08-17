using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 日志查询结果
/// </summary>
public class LogQueryResult
{
    /// <summary>
    /// 日志列表
    /// </summary>
    [JsonPropertyName("logs")]
    public List<string>? Logs { get; set; }

    /// <summary>
    /// 分页节点
    /// </summary>
    [JsonPropertyName("qnode")]
    public LogQueryNode? QNode { get; set; }
}

/// <summary>
/// 日志分页节点
/// </summary>
public class LogQueryNode
{
    /// <summary>
    /// 最后一条日志的id
    /// </summary>
    [JsonPropertyName("last_id")]
    public long LastId { get; set; }

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
    /// 开始id
    /// </summary>
    [JsonPropertyName("start_id")]
    public long StartId { get; set; }
}
