using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置网络参数请求
/// </summary>
public class SetNetworkParamRequest : BaseRequest, IRequest<SetNetworkParamRequest,SetNetworkParamResponse>
{
    public SetNetworkParamRequest()
    {
        Cmd = "set_networkparam";
    }

    [JsonPropertyName("body")]
    public NetworkParam? Body { get; set; }
}

/// <summary>
/// 设置网络参数响应
/// </summary>
public class SetNetworkParamResponse : BaseResponse
{
}

/// <summary>
/// 获取网络参数请求
/// </summary>
public class GetNetworkParamRequest : BaseRequest, IRequest<GetNetworkParamRequest,GetNetworkParamResponse>
{
    public GetNetworkParamRequest()
    {
        Cmd = "get_networkparam";
    }

    /// <summary>
    /// 网口号0|1
    /// </summary>
    [JsonPropertyName("source")]
    public int? Source { get; set; }
}

/// <summary>
/// 获取网络参数响应
/// </summary>
public class GetNetworkParamResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public NetworkParam? Body { get; set; }
}
