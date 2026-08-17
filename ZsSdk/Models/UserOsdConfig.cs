using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 用户自定义OSD配置
/// </summary>
public class UserOsdConfig
{
    /// <summary>
    /// OSD参数列表
    /// </summary>
    [JsonPropertyName("user_osd_param")]
    public List<UserOsdParam>? UserOsdParam { get; set; }

    /// <summary>
    /// 横坐标百分比，取值范围０到１００
    /// </summary>
    [JsonPropertyName("x_pos")]
    public int XPos { get; set; }

    /// <summary>
    /// 纵坐标百分比，取值范围０到１００
    /// </summary>
    [JsonPropertyName("y_pos")]
    public int YPos { get; set; }
}
