using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 识别结果推送消息
/// </summary>
public class IvsResultMessage
{
    /// <summary>
    /// 车牌识别结果
    /// </summary>
    [JsonPropertyName("PlateResult")]
    public PlateResult? PlateResult { get; set; }

    /// <summary>
    /// 车牌加密方式
    /// </summary>
    [JsonPropertyName("active_id")]
    public int ActiveId { get; set; }

    /// <summary>
    /// 车牌区域图片的尺寸（字节数）
    /// </summary>
    [JsonPropertyName("clipImgSize")]
    public int ClipImgSize { get; set; }

    /// <summary>
    /// 当前指令名称
    /// </summary>
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    /// <summary>
    /// 整幅大图的尺寸（字节数）
    /// </summary>
    [JsonPropertyName("fullImgSize")]
    public int FullImgSize { get; set; }

    /// <summary>
    /// 识别记录的编号
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 图片格式
    /// </summary>
    [JsonPropertyName("imageformat")]
    public string? ImageFormat { get; set; }

    /// <summary>
    /// 触发时间字符串，格式如：2015-01-02 03:04:05
    /// </summary>
    [JsonPropertyName("timeString")]
    public string? TimeString { get; set; }
}
