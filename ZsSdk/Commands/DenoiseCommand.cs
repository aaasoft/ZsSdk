using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取降噪参数请求
/// </summary>
public class GetDenoiseRequest : BaseRequest, IRequest<GetDenoiseRequest, GetDenoiseResponse>
{
    public GetDenoiseRequest()
    {
        Cmd = "get_denoise";
    }
}

/// <summary>
/// 获取降噪参数响应
/// </summary>
public class GetDenoiseResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public DenoiseParam? Body { get; set; }
}

/// <summary>
/// 设置降噪参数请求
/// </summary>
public class SetDenoiseRequest : BaseRequest, IRequest<SetDenoiseRequest, SetDenoiseResponse>
{
    public SetDenoiseRequest()
    {
        Cmd = "set_denoise";
    }

    [JsonPropertyName("body")]
    public DenoiseParam? Body { get; set; }
}

/// <summary>
/// 设置降噪参数响应
/// </summary>
public class SetDenoiseResponse : BaseResponse
{
}
