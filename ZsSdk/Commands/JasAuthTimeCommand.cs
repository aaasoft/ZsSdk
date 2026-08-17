using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 建安顺APP过期设置请求
/// </summary>
public class JasAuthTimeRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "jasauthtime";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonPropertyName("mon")]
    public int Month { get; set; }

    [JsonPropertyName("day")]
    public int Day { get; set; }

    [JsonPropertyName("hour")]
    public int Hour { get; set; }

    [JsonPropertyName("min")]
    public int Minute { get; set; }

    [JsonPropertyName("sec")]
    public int Second { get; set; }
}

/// <summary>
/// 建安顺APP过期设置响应
/// </summary>
public class JasAuthTimeResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
