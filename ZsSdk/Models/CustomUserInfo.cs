using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 自定义设备信息
/// </summary>
public class CustomUserInfo
{
    /// <summary>
    /// 字符串标识的协议适配厂家
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    /// <summary>
    /// 自定义信息
    /// </summary>
    [JsonPropertyName("data")]
    public CustomUserData? Data { get; set; }
}

/// <summary>
/// 自定义用户数据
/// </summary>
public class CustomUserData
{
    /// <summary>
    /// 版本，整数0~4，0表示没有设置
    /// </summary>
    [JsonPropertyName("ver")]
    public int Ver { get; set; }

    /// <summary>
    /// 是否支持变焦，整数0~2，1不支持，2支持，0表示没有设置
    /// </summary>
    [JsonPropertyName("is_zoom")]
    public int IsZoom { get; set; }

    /// <summary>
    /// 设备等级（或分类），整数0~16，0表示没有设置
    /// </summary>
    [JsonPropertyName("class")]
    public int Class { get; set; }
}
