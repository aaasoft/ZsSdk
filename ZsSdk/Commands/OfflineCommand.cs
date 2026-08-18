using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 注册脱机功能请求
/// </summary>
public class RegOfflineCheckRequest : BaseRequest, IRequest<OfflineCheckResponse>
{
    public RegOfflineCheckRequest()
    {
        Cmd = "reg_offline_check";
    }

    /// <summary>
    /// 脱机响应的超时时间（秒为单位）
    /// </summary>
    [JsonPropertyName("interval")]
    public int Interval { get; set; }
}

/// <summary>
/// 取消脱机注册请求
/// </summary>
public class CancelOfflineCheckRequest : BaseRequest, IRequest<OfflineCheckResponse>
{
    public CancelOfflineCheckRequest()
    {
        Cmd = "reg_offline_check";
    }

    [JsonPropertyName("sucmd")]
    public string SubCmd { get; set; } = "cancel";
}

/// <summary>
/// 脱机功能响应
/// </summary>
public class OfflineCheckResponse : BaseResponse
{
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// 注册脱机事件请求
/// </summary>
public class RegisterOfflineEventRequest : BaseRequest, IRequest<RegisterOfflineEventResponse>
{
    public RegisterOfflineEventRequest()
    {
        Cmd = "register_offline_event";
    }

    [JsonPropertyName("body")]
    public RegisterOfflineEventBody? Body { get; set; }
}

/// <summary>
/// 注册脱机事件请求体
/// </summary>
public class RegisterOfflineEventBody
{
    /// <summary>
    /// 注册状态，当发生改变且register_status!=0时，会收到改变响应消息
    /// </summary>
    [JsonPropertyName("register_status")]
    public int RegisterStatus { get; set; }
}

/// <summary>
/// 注册脱机事件响应
/// </summary>
public class RegisterOfflineEventResponse : BaseResponse
{
}

/// <summary>
/// 脱机状态改变消息
/// </summary>
public class OfflineStatusChangeMessage
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "offline_status_change";

    [JsonPropertyName("body")]
    public OfflineStatusChangeBody? Body { get; set; }
}

/// <summary>
/// 脱机状态改变消息体
/// </summary>
public class OfflineStatusChangeBody
{
    /// <summary>
    /// 当前脱机状态；0：脱机，1：在线
    /// </summary>
    [JsonPropertyName("offline_status")]
    public int OfflineStatus { get; set; }
}

/// <summary>
/// 获取脱机状态请求
/// </summary>
public class GetOfflineStatusRequest : BaseRequest, IRequest<GetOfflineStatusResponse>
{
    public GetOfflineStatusRequest()
    {
        Cmd = "get_offline_status";
    }
}

/// <summary>
/// 获取脱机状态响应
/// </summary>
public class GetOfflineStatusResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public OfflineStatusChangeBody? Body { get; set; }
}
