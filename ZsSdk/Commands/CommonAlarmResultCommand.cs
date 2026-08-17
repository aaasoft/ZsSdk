using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 通用报警结果消息（人车滞留事件）
/// </summary>
public class CommonAlarmResultMessage
{
    [JsonPropertyName("module")]
    public string? Module { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("device_info")]
    public AlarmDeviceInfo? DeviceInfo { get; set; }

    [JsonPropertyName("full_image")]
    public List<AlarmImage>? FullImage { get; set; }

    [JsonPropertyName("small_image")]
    public List<AlarmImage>? SmallImage { get; set; }

    [JsonPropertyName("results")]
    public List<AlarmResult>? Results { get; set; }
}

/// <summary>
/// 报警设备信息
/// </summary>
public class AlarmDeviceInfo
{
    [JsonPropertyName("alg_chn")]
    public int AlgChn { get; set; }

    [JsonPropertyName("chn_id")]
    public int ChnId { get; set; }

    [JsonPropertyName("dev_ip")]
    public string? DevIp { get; set; }

    [JsonPropertyName("dev_port")]
    public int DevPort { get; set; }

    [JsonPropertyName("rule_id")]
    public int RuleId { get; set; }
}

/// <summary>
/// 报警图片信息
/// </summary>
public class AlarmImage
{
    [JsonPropertyName("full_image_id")]
    public int FullImageId { get; set; }

    [JsonPropertyName("small_image_id")]
    public int SmallImageId { get; set; }

    [JsonPropertyName("image_type")]
    public int ImageType { get; set; }

    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    [JsonPropertyName("fe_crop_info")]
    public Rect? FeCropInfo { get; set; }
}

/// <summary>
/// 报警结果
/// </summary>
public class AlarmResult
{
    [JsonPropertyName("event_type")]
    public int EventType { get; set; }

    [JsonPropertyName("group_id")]
    public int GroupId { get; set; }

    [JsonPropertyName("plate_result")]
    public AlarmPlateResult? PlateResult { get; set; }

    [JsonPropertyName("lane_ctrl_prop")]
    public LaneCtrlProp? LaneCtrlProp { get; set; }

    [JsonPropertyName("result_id")]
    public int ResultId { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("trigger_type")]
    public int TriggerType { get; set; }

    [JsonPropertyName("image_id")]
    public int ImageId { get; set; }
}

/// <summary>
/// 报警车牌结果
/// </summary>
public class AlarmPlateResult
{
    [JsonPropertyName("color_type")]
    public string? ColorType { get; set; }

    [JsonPropertyName("confidence")]
    public int Confidence { get; set; }

    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("plate_true_width")]
    public int PlateTrueWidth { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// 车道控制属性
/// </summary>
public class LaneCtrlProp
{
    [JsonPropertyName("car_stay_result")]
    public StayResult? CarStayResult { get; set; }

    [JsonPropertyName("person_stay_result")]
    public StayResult? PersonStayResult { get; set; }

    [JsonPropertyName("image_id")]
    public int ImageId { get; set; }
}

/// <summary>
/// 滞留结果
/// </summary>
public class StayResult
{
    /// <summary>
    /// 报警状态：0正常 1报警
    /// </summary>
    [JsonPropertyName("alarm_state")]
    public int AlarmState { get; set; }
}
