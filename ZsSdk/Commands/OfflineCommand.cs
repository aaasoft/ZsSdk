using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 注册脱机功能请求
/// </summary>
public class RegOfflineCheckRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "reg_offline_check";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 脱机响应的超时时间（秒为单位）
    /// </summary>
    [JsonPropertyName("interval")]
    public int Interval { get; set; }
}

/// <summary>
/// 取消脱机注册请求
/// </summary>
public class CancelOfflineCheckRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "reg_offline_check";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("sucmd")]
    public string SubCmd { get; set; } = "cancel";
}

/// <summary>
/// 脱机功能响应
/// </summary>
public class OfflineCheckResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>
/// 注册脱机事件请求
/// </summary>
public class RegisterOfflineEventRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "register_offline_event";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class RegisterOfflineEventResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
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
public class GetOfflineStatusRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_offline_status";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取脱机状态响应
/// </summary>
public class GetOfflineStatusResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public OfflineStatusChangeBody? Body { get; set; }
}
