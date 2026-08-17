using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置系统时间请求
/// </summary>
public class SetTimeRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_time";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 时间字符串，格式必须是："XXXX-XX-XX XX:XX:XX"
    /// </summary>
    [JsonPropertyName("timestring")]
    public string? TimeString { get; set; }
}

/// <summary>
/// 设置系统时间响应
/// </summary>
public class SetTimeResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
