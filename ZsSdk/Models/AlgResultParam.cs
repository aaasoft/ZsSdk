using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 算法识别参数
/// </summary>
public class AlgResultParam
{
    /// <summary>
    /// 抓拍图片分辨率
    /// </summary>
    [JsonPropertyName("snap_resolution")]
    public int SnapResolution { get; set; }

    /// <summary>
    /// 抓拍图片质量，单位百分比
    /// </summary>
    [JsonPropertyName("snap_image_quality")]
    public int SnapImageQuality { get; set; }

    /// <summary>
    /// 输出类型
    /// </summary>
    [JsonPropertyName("out_result_type")]
    public int OutResultType { get; set; }

    /// <summary>
    /// 识别类型
    /// </summary>
    [JsonPropertyName("recognition_type")]
    public int RecognitionType { get; set; }

    /// <summary>
    /// 预设省份
    /// </summary>
    [JsonPropertyName("province")]
    public int Province { get; set; }

    /// <summary>
    /// 运行模式
    /// </summary>
    [JsonPropertyName("run_mode")]
    public int RunMode { get; set; }

    /// <summary>
    /// 算法版本
    /// </summary>
    [JsonPropertyName("alg_version")]
    public string? AlgVersion { get; set; }

    /// <summary>
    /// 时区
    /// </summary>
    [JsonPropertyName("time_zone")]
    public int TimeZone { get; set; }

    /// <summary>
    /// 识别距离 0:1-6米 1: 大于6米
    /// </summary>
    [JsonPropertyName("reco_dis")]
    public int RecoDis { get; set; }
}
