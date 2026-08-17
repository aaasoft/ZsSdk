using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备序列号请求
/// </summary>
public class GetSnRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "getsn";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取设备序列号响应
/// </summary>
public class GetSnResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 设备序列号：正确值为17位长的字符串，前8位 + '-' + 后8位
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
