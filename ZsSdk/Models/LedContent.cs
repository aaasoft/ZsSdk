using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// LED显示内容
/// </summary>
public class LedContent
{
    /// <summary>
    /// 屏显协议
    /// </summary>
    [JsonPropertyName("led_proto")]
    public int LedProto { get; set; }

    /// <summary>
    /// 屏显状态
    /// </summary>
    [JsonPropertyName("led_status")]
    public int LedStatus { get; set; }

    /// <summary>
    /// 屏显内容定时刷新时间[6,15]
    /// </summary>
    [JsonPropertyName("led_refresh_time")]
    public int LedRefreshTime { get; set; }

    /// <summary>
    /// 屏幕支持行数(目前最大支持4行)
    /// </summary>
    [JsonPropertyName("led_line_num")]
    public int LedLineNum { get; set; }

    /// <summary>
    /// 屏显每行具体内容
    /// </summary>
    [JsonPropertyName("line_content")]
    public List<LineContent>? LineContent { get; set; }
}
