using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 云台控制请求
/// </summary>
public class SetCloudCtrlRequest : BaseRequest, IRequest<SetCloudCtrlResponse>
{
    public SetCloudCtrlRequest()
    {
        Cmd = "set_cloud_ctrl";
    }

    [JsonPropertyName("body")]
    public SetCloudCtrlBody? Body { get; set; }
}

/// <summary>
/// 云台控制请求体
/// </summary>
public class SetCloudCtrlBody
{
    /// <summary>
    /// 方向：0设置超时时间 1保持继续移动 2向上移动 3保持向上移动 4向下移动 5保持向下移动 8停止上下移动 16向左移动 17保持向左移动 32向右移动 33保持向右移动 64停止左右移动
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// type=0的时候，此字段为设置超时时间，单位毫秒，其他情况时这个字段可以不填或者填-1
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>
/// 云台控制响应
/// </summary>
public class SetCloudCtrlResponse : BaseResponse
{
}
