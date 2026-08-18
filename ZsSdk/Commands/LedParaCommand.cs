using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置LED参数请求
/// </summary>
public class SetLedParaRequest : BaseRequest, IRequest<SetLedParaResponse>
{
    public SetLedParaRequest()
    {
        Cmd = "set_led_para";
    }

    [JsonPropertyName("body")]
    public LedParam? Body { get; set; }
}

/// <summary>
/// 设置LED参数响应
/// </summary>
public class SetLedParaResponse : BaseResponse
{
}

/// <summary>
/// 获取LED参数请求
/// </summary>
public class GetLedParaRequest : BaseRequest, IRequest<GetLedParaResponse>
{
    public GetLedParaRequest()
    {
        Cmd = "get_led_para";
    }
}

/// <summary>
/// 获取LED参数响应
/// </summary>
public class GetLedParaResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public LedParam? Body { get; set; }
}
