using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置设备有效时间请求
/// </summary>
public class SetDeviceActiveSettingsRequest : BaseRequest, IRequest<SetDeviceActiveSettingsRequest, SetDeviceActiveSettingsResponse>
{
    public SetDeviceActiveSettingsRequest()
    {
        Cmd = "device_active_settings";
    }

    [JsonPropertyName("body")]
    public SetDeviceActiveStatusBody? Body { get; set; }
}

/// <summary>
/// 设置设备有效时间请求体
/// </summary>
public class SetDeviceActiveStatusBody
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "set_device_active_status";

    /// <summary>
    /// 是否启用相机授权：0不启用 1启用
    /// </summary>
    [JsonPropertyName("active_status")]
    public int ActiveStatus { get; set; }

    /// <summary>
    /// 相机授权时间，单位秒
    /// </summary>
    [JsonPropertyName("active_time")]
    public int ActiveTime { get; set; }

    /// <summary>
    /// 加密后再经过64位编码的用户密码
    /// </summary>
    [JsonPropertyName("authentication")]
    public string? Authentication { get; set; }
}

/// <summary>
/// 设置设备有效时间响应
/// </summary>
public class SetDeviceActiveSettingsResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public DeviceActiveStatusState? Body { get; set; }
}

/// <summary>
/// 设备有效时间状态
/// </summary>
public class DeviceActiveStatusState
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }
}

/// <summary>
/// 获取设备有效时间请求
/// </summary>
public class GetDeviceActiveSettingsRequest : BaseRequest, IRequest<GetDeviceActiveSettingsRequest, GetDeviceActiveSettingsResponse>
{
    public GetDeviceActiveSettingsRequest()
    {
        Cmd = "device_active_settings";
    }

    [JsonPropertyName("body")]
    public GetDeviceActiveStatusBody? Body { get; set; }
}

/// <summary>
/// 获取设备有效时间请求体
/// </summary>
public class GetDeviceActiveStatusBody
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "get_device_active_status";
}

/// <summary>
/// 获取设备有效时间响应
/// </summary>
public class GetDeviceActiveSettingsResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public GetDeviceActiveStatusResult? Body { get; set; }
}

/// <summary>
/// 获取设备有效时间结果
/// </summary>
public class GetDeviceActiveStatusResult
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }

    [JsonPropertyName("active_status")]
    public int ActiveStatus { get; set; }

    [JsonPropertyName("active_time")]
    public int ActiveTime { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}
