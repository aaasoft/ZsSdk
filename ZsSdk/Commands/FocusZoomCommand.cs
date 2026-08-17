using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 开始自动聚焦请求
/// </summary>
public class StartFocusAndZoomRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "startfocusandzoom";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public StartFocusAndZoomBody? Body { get; set; }
}

/// <summary>
/// 开始自动聚焦请求体
/// </summary>
public class StartFocusAndZoomBody
{
    /// <summary>
    /// 自动变倍/调焦：0停止 1focus焦增加 2focus焦减小 3zoom变倍增加 4zoom变倍减小
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>
/// 开始自动聚焦响应
/// </summary>
public class StartFocusAndZoomResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 停止自动聚焦请求
/// </summary>
public class StopFocusAndZoomRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "stopfocusandzoom";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 停止自动聚焦响应
/// </summary>
public class StopFocusAndZoomResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
