using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置设备名称请求
/// </summary>
public class SetDevNameRequest : BaseRequest, IRequest<SetDevNameRequest,SetDevNameResponse>
{
    public SetDevNameRequest()
    {
        Cmd = "set_dev_name";
    }

    [JsonPropertyName("body")]
    public SetDevNameBody? Body { get; set; }
}

/// <summary>
/// 设置设备名称请求体
/// </summary>
public class SetDevNameBody
{
    /// <summary>
    /// 设置设备名称。大小限制：最大60个字节
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 设置设备名称响应
/// </summary>
public class SetDevNameResponse : BaseResponse
{
}
