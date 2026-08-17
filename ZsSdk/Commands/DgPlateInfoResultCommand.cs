using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 组网识别消息结果
/// </summary>
public class DgPlateInfoResultMessage
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public DgPlateInfoResultBody? Body { get; set; }
}

/// <summary>
/// 组网识别消息结果体
/// </summary>
public class DgPlateInfoResultBody
{
    /// <summary>
    /// 消息类型：output出口消息 input入口消息
    /// </summary>
    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }

    /// <summary>
    /// 入口记录
    /// </summary>
    [JsonPropertyName("input_record")]
    public DgRecord? InputRecord { get; set; }

    /// <summary>
    /// 出口记录
    /// </summary>
    [JsonPropertyName("output_record")]
    public DgRecord? OutputRecord { get; set; }
}

/// <summary>
/// 组网记录
/// </summary>
public class DgRecord
{
    [JsonPropertyName("device_name")]
    public DgDeviceName? DeviceName { get; set; }

    [JsonPropertyName("ivs_result_param")]
    public DgIvsResultParam? IvsResultParam { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }
}

/// <summary>
/// 组网设备名称
/// </summary>
public class DgDeviceName
{
    [JsonPropertyName("enable_group")]
    public bool EnableGroup { get; set; }

    [JsonPropertyName("ip_addr")]
    public string? IpAddr { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sn")]
    public string? Sn { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// 组网识别结果参数
/// </summary>
public class DgIvsResultParam
{
    [JsonPropertyName("bright")]
    public int Bright { get; set; }

    [JsonPropertyName("car_bright")]
    public int CarBright { get; set; }

    [JsonPropertyName("car_color")]
    public int CarColor { get; set; }

    [JsonPropertyName("confidence")]
    public int Confidence { get; set; }

    [JsonPropertyName("direction")]
    public int Direction { get; set; }

    [JsonPropertyName("fragment_path")]
    public string? FragmentPath { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("image_path")]
    public string? ImagePath { get; set; }

    [JsonPropertyName("image_sd_path")]
    public string? ImageSdPath { get; set; }

    [JsonPropertyName("location")]
    public DgLocation? Location { get; set; }

    [JsonPropertyName("n_time")]
    public int NTime { get; set; }

    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    [JsonPropertyName("plate_color")]
    public int PlateColor { get; set; }

    [JsonPropertyName("plate_type")]
    public int PlateType { get; set; }

    [JsonPropertyName("related_plate")]
    public string? RelatedPlate { get; set; }

    [JsonPropertyName("timeval")]
    public DgTimeval? Timeval { get; set; }

    [JsonPropertyName("trig_type")]
    public int TrigType { get; set; }
}

/// <summary>
/// 组网位置信息
/// </summary>
public class DgLocation
{
    [JsonPropertyName("bottom")]
    public int Bottom { get; set; }

    [JsonPropertyName("left")]
    public int Left { get; set; }

    [JsonPropertyName("right")]
    public int Right { get; set; }

    [JsonPropertyName("top")]
    public int Top { get; set; }
}

/// <summary>
/// 组网时间信息
/// </summary>
public class DgTimeval
{
    [JsonPropertyName("decday")]
    public int DecDay { get; set; }

    [JsonPropertyName("dechour")]
    public int DecHour { get; set; }

    [JsonPropertyName("decmin")]
    public int DecMin { get; set; }

    [JsonPropertyName("decmon")]
    public int DecMon { get; set; }

    [JsonPropertyName("decsec")]
    public int DecSec { get; set; }

    [JsonPropertyName("decyear")]
    public int DecYear { get; set; }

    [JsonPropertyName("tv_sec")]
    public long TvSec { get; set; }

    [JsonPropertyName("tv_usec")]
    public long TvUsec { get; set; }
}
