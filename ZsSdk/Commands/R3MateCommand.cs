using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 通过R3获取指定伴侣机的配置信息请求
/// </summary>
public class UserGetMateInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "user_get_mate_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 通过R3获取指定伴侣机的配置信息响应
/// </summary>
public class UserGetMateInfoResponse
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
    public List<DeviceInfo>? Body { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的Rtsp代理信息请求
/// </summary>
public class UserGetRtspInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "user_get_rtsp_info";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public UserGetRtspInfoBody? Body { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的Rtsp代理信息请求体
/// </summary>
public class UserGetRtspInfoBody
{
    /// <summary>
    /// 伴侣机的序列号
    /// </summary>
    [JsonPropertyName("sn")]
    public string? Sn { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的Rtsp代理信息响应
/// </summary>
public class UserGetRtspInfoResponse
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
    public RtspInfo? Body { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的语音代理信息请求
/// </summary>
public class UserRequestTalkbackRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "user_request_talkback";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public UserRequestTalkbackBody? Body { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的语音代理信息请求体
/// </summary>
public class UserRequestTalkbackBody
{
    /// <summary>
    /// 伴侣机的序列号
    /// </summary>
    [JsonPropertyName("sn")]
    public string? Sn { get; set; }

    /// <summary>
    /// 每次发送数据包的大小，建议设置为320
    /// </summary>
    [JsonPropertyName("window_size")]
    public int WindowSize { get; set; }
}

/// <summary>
/// 通过R3获取伴侣机的语音代理信息响应
/// </summary>
public class UserRequestTalkbackResponse
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
    public TalkbackParam? Body { get; set; }
}

/// <summary>
/// 通过Tcp获取日志请求
/// </summary>
public class LogSearchRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "log_search";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public LogQueryParam? Body { get; set; }
}

/// <summary>
/// 通过Tcp获取日志响应
/// </summary>
public class LogSearchResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; set; }

    [JsonPropertyName("body")]
    public LogQueryResult? Body { get; set; }
}

/// <summary>
/// 设置Rg人车滞留事件上报使能请求
/// </summary>
public class StayEventEnableRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "stay_event_enable";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public StayEventEnableBody? Body { get; set; }
}

/// <summary>
/// 设置Rg人车滞留事件上报使能请求体
/// </summary>
public class StayEventEnableBody
{
    /// <summary>
    /// 是否允许推送识别结果，默认值：false
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>
    /// 推送识别结果数据格式，默认值：json
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// 识别结果是否包含图片，默认值：true
    /// </summary>
    [JsonPropertyName("image")]
    public bool Image { get; set; } = true;

    /// <summary>
    /// 识别的图片类型，默认值：0
    /// </summary>
    [JsonPropertyName("image_type")]
    public int ImageType { get; set; }
}

/// <summary>
/// 设置Rg人车滞留事件上报使能响应
/// </summary>
public class StayEventEnableResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
