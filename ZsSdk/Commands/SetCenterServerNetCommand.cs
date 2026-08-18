using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置中心服务器网络参数请求
/// </summary>
public class SetCenterServerNetRequest : BaseRequest, IRequest<SetCenterServerNetResponse>
{
    public SetCenterServerNetRequest()
    {
        Cmd = "set_centerserver_net";
    }

    [JsonPropertyName("body")]
    public CenterServerParam? Body { get; set; }
}

/// <summary>
/// 设置中心服务器网络参数响应
/// </summary>
public class SetCenterServerNetResponse : BaseResponse
{
}
