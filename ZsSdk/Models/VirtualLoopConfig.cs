using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 虚拟线圈配置
/// </summary>
public class VirtualLoopConfig
{
    /// <summary>
    /// 最大车牌尺寸
    /// </summary>
    [JsonPropertyName("max_plate_width")]
    public int MaxPlateWidth { get; set; }

    /// <summary>
    /// 最小车牌尺寸
    /// </summary>
    [JsonPropertyName("min_plate_width")]
    public int MinPlateWidth { get; set; }

    /// <summary>
    /// 运动方向
    /// </summary>
    [JsonPropertyName("dir")]
    public int Dir { get; set; }

    /// <summary>
    /// 相同车牌的触发时间间隔
    /// </summary>
    [JsonPropertyName("trigger_gap")]
    public int TriggerGap { get; set; }

    /// <summary>
    /// 虚拟线圈数量
    /// </summary>
    [JsonPropertyName("virtualloop_num")]
    public int VirtualLoopNum { get; set; }

    /// <summary>
    /// 线圈列表
    /// </summary>
    [JsonPropertyName("loop")]
    public List<VirtualLoop>? Loops { get; set; }
}
