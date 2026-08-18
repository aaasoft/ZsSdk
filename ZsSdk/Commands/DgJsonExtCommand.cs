using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取组网匹配模式请求
/// </summary>
public class GetDeviceMatchModeRequest : DgJsonRequest
{
    public GetDeviceMatchModeRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_device_match_mode" };
    }
}

/// <summary>
/// 设置组网匹配模式请求
/// </summary>
public class SetDeviceMatchModeRequest : DgJsonRequest
{
    public SetDeviceMatchModeRequest()
    {
        Body = new SetDeviceMatchModeBody();
    }
}

/// <summary>
/// 设置组网匹配模式请求体
/// </summary>
public class SetDeviceMatchModeBody : DgJsonRequestBody
{
    public SetDeviceMatchModeBody()
    {
        Type = "set_device_match_mode";
    }

    /// <summary>
    /// 匹配模式
    /// </summary>
    [JsonPropertyName("match_mode")]
    public int MatchMode { get; set; }
}

/// <summary>
/// 得到组网共享IO请求
/// </summary>
public class GetGroupSharedIoRequest : DgJsonRequest
{
    public GetGroupSharedIoRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_group_shared_io" };
    }
}

/// <summary>
/// 设置组网共享IO请求
/// </summary>
public class SetGroupSharedIoRequest : DgJsonRequest
{
    public SetGroupSharedIoRequest()
    {
        Body = new SetGroupSharedIoBody();
    }
}

/// <summary>
/// 设置组网共享IO请求体
/// </summary>
public class SetGroupSharedIoBody : DgJsonRequestBody
{
    public SetGroupSharedIoBody()
    {
        Type = "set_group_shared_io";
    }

    /// <summary>
    /// 共享IO配置
    /// </summary>
    [JsonPropertyName("shared_io")]
    public List<SharedIoConfig>? SharedIo { get; set; }
}

/// <summary>
/// 共享IO配置
/// </summary>
public class SharedIoConfig
{
    /// <summary>
    /// IO编号
    /// </summary>
    [JsonPropertyName("io")]
    public int Io { get; set; }

    /// <summary>
    /// 是否共享
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }
}

/// <summary>
/// 组网识别结果消息请求
/// </summary>
public class EnableDgResultRequest : DgJsonRequest
{
    public EnableDgResultRequest()
    {
        Body = new EnableDgResultBody();
    }
}

/// <summary>
/// 组网识别结果消息请求体
/// </summary>
public class EnableDgResultBody : DgJsonRequestBody
{
    public EnableDgResultBody()
    {
        Type = "enable_dg_result";
    }

    /// <summary>
    /// 是否启用
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }
}

/// <summary>
/// 设置设备组网类型及参数请求
/// </summary>
public class SetDeviceTypeEnableRequest : DgJsonRequest
{
    public SetDeviceTypeEnableRequest()
    {
        Body = new SetDeviceTypeEnableBody();
    }
}

/// <summary>
/// 设置设备组网类型及参数请求体
/// </summary>
public class SetDeviceTypeEnableBody : DgJsonRequestBody
{
    public SetDeviceTypeEnableBody()
    {
        Type = "set_device_type_enable";
    }

    [JsonPropertyName("vzid")]
    public Models.VzId? VzId { get; set; }
}
