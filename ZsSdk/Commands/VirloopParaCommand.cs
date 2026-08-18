using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取虚拟线圈参数请求
/// </summary>
public class GetVirloopParaRequest : BaseRequest, IRequest<GetVirloopParaRequest,GetVirloopParaResponse>
{
    public GetVirloopParaRequest()
    {
        Cmd = "get_virloop_para";
    }
}

/// <summary>
/// 获取虚拟线圈参数响应
/// </summary>
public class GetVirloopParaResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public VirloopParaBody? Body { get; set; }
}

/// <summary>
/// 虚拟线圈参数响应体
/// </summary>
public class VirloopParaBody
{
    [JsonPropertyName("virtualloop")]
    public VirtualLoopConfig? VirtualLoop { get; set; }
}

/// <summary>
/// 设置虚拟线圈参数请求
/// </summary>
public class SetVirloopParaRequest : BaseRequest, IRequest<SetVirloopParaRequest,SetVirloopParaResponse>
{
    public SetVirloopParaRequest()
    {
        Cmd = "set_virloop_para";
    }

    [JsonPropertyName("body")]
    public VirloopParaBody? Body { get; set; }
}

/// <summary>
/// 设置虚拟线圈参数响应
/// </summary>
public class SetVirloopParaResponse : BaseResponse
{
}
