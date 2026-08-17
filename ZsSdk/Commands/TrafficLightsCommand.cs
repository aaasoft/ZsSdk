using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 获取交通灯状态请求
/// </summary>
public class GetTrafficLightsRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_traffic_lights";
}

/// <summary>
/// 获取交通灯状态响应
/// </summary>
public class GetTrafficLightsResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("body")]
    public TrafficLightsParam? Body { get; set; }
}

/// <summary>
/// 交通灯参数
/// </summary>
public class TrafficLightsParam
{
    /// <summary>
    /// 是否启用交通灯控制 0：不启用 1：启用
    /// </summary>
    [JsonPropertyName("enable")]
    public int Enable { get; set; }

    /// <summary>
    /// 绿灯控制IO口
    /// </summary>
    [JsonPropertyName("green_gpio")]
    public int GreenGpio { get; set; }

    /// <summary>
    /// 红灯控制IO口
    /// </summary>
    [JsonPropertyName("red_gpio")]
    public int RedGpio { get; set; }

    /// <summary>
    /// 开闸绿灯延时时间(单位：ms)
    /// </summary>
    [JsonPropertyName("time")]
    public int Time { get; set; }
}

/// <summary>
/// 设置交通灯功能请求
/// </summary>
public class SetTrafficLightsRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_traffic_lights";

    [JsonPropertyName("body")]
    public TrafficLightsParam? Body { get; set; }
}

/// <summary>
/// 设置交通灯功能响应
/// </summary>
public class SetTrafficLightsResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}
