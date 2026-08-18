using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取算法识别参数请求
/// </summary>
public class GetAlgResultParaRequest : BaseRequest, IRequest<GetAlgResultParaResponse>
{
    public GetAlgResultParaRequest()
    {
        Cmd = "get_alg_result_para";
    }
}

/// <summary>
/// 获取算法识别参数响应
/// </summary>
public class GetAlgResultParaResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public AlgResultParam? Body { get; set; }
}

/// <summary>
/// 设置算法识别参数请求
/// </summary>
public class SetAlgResultParaRequest : BaseRequest, IRequest<SetAlgResultParaResponse>
{
    public SetAlgResultParaRequest()
    {
        Cmd = "set_alg_result_para";
    }

    [JsonPropertyName("body")]
    public AlgResultParam? Body { get; set; }
}

/// <summary>
/// 设置算法识别参数响应
/// </summary>
public class SetAlgResultParaResponse : BaseResponse
{
}
