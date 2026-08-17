using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 组网配置
/// </summary>
public class GroupConfig
{
    /// <summary>
    /// 组网内所有设备配置信息
    /// </summary>
    [JsonPropertyName("group_vzids")]
    public List<GroupDeviceConfig>? GroupVzIds { get; set; }
}
