using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取识别区域参数请求
/// </summary>
public class GetRecoParaRequest : BaseRequest, IRequest<GetRecoParaResponse>
{
    public GetRecoParaRequest()
    {
        Cmd = "get_reco_para";
    }
}

/// <summary>
/// 获取识别区域参数响应
/// </summary>
public class GetRecoParaResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public RecoParaBody? Body { get; set; }
}

/// <summary>
/// 识别区域参数响应体
/// </summary>
public class RecoParaBody
{
    [JsonPropertyName("recognition_area")]
    public RecognitionAreaConfig? RecognitionArea { get; set; }
}

/// <summary>
/// 设置识别区域参数请求
/// </summary>
public class SetRecoParaRequest : BaseRequest, IRequest<SetRecoParaResponse>
{
    public SetRecoParaRequest()
    {
        Cmd = "set_reco_para";
    }

    [JsonPropertyName("body")]
    public RecoParaBody? Body { get; set; }
}

/// <summary>
/// 设置识别区域参数响应
/// </summary>
public class SetRecoParaResponse : BaseResponse
{
}
