using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 重启设备请求
/// </summary>
public class RebootDevRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "reboot_dev";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 重启设备响应
/// </summary>
public class RebootDevResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
