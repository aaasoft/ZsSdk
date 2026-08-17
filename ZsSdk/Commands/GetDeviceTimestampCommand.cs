using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备当前时间戳请求
/// </summary>
public class GetDeviceTimestampRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_device_timestamp";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取设备当前时间戳响应
/// </summary>
public class GetDeviceTimestampResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 时间（格林威治时间，单位秒）
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
}
