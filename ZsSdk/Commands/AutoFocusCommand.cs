using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 自动聚焦请求
/// </summary>
public class AutoFocusRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "auto_focus";
}

/// <summary>
/// 自动聚焦响应
/// </summary>
public class AutoFocusResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
