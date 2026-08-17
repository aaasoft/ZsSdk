using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 存储设备信息
/// </summary>
public class DiskInfo
{
    /// <summary>
    /// 当前磁盘名称
    /// </summary>
    [JsonPropertyName("devname")]
    public string? DevName { get; set; }

    /// <summary>
    /// 磁盘总内存
    /// </summary>
    [JsonPropertyName("devtotal")]
    public int DevTotal { get; set; }

    /// <summary>
    /// 磁盘类型：0 SD卡 1 HD卡
    /// </summary>
    [JsonPropertyName("devtype")]
    public int DevType { get; set; }

    /// <summary>
    /// 分区信息
    /// </summary>
    [JsonPropertyName("devparts")]
    public List<DiskPartition>? DevParts { get; set; }
}

/// <summary>
/// 磁盘分区信息
/// </summary>
public class DiskPartition
{
    /// <summary>
    /// 分区名称
    /// </summary>
    [JsonPropertyName("partname")]
    public string? PartName { get; set; }

    /// <summary>
    /// 格式化百分比
    /// </summary>
    [JsonPropertyName("formatpercent")]
    public int FormatPercent { get; set; }

    /// <summary>
    /// 分区空间
    /// </summary>
    [JsonPropertyName("partspace")]
    public DiskSpace? PartSpace { get; set; }

    /// <summary>
    /// 分区状态
    /// </summary>
    [JsonPropertyName("partstate")]
    public int PartState { get; set; }
}

/// <summary>
/// 磁盘空间信息
/// </summary>
public class DiskSpace
{
    /// <summary>
    /// 总空间
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// 已使用空间
    /// </summary>
    [JsonPropertyName("used")]
    public int Used { get; set; }

    /// <summary>
    /// 剩余空间
    /// </summary>
    [JsonPropertyName("left")]
    public int Left { get; set; }
}
