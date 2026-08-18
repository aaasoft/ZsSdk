using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备序列号请求
/// </summary>
public class GetSnRequest : BaseRequest, IRequest<GetSnRequest,GetSnResponse>
{
    public GetSnRequest()
    {
        Cmd = "getsn";
    }
}

/// <summary>
/// 获取设备序列号响应
/// </summary>
public class GetSnResponse : BaseResponse
{
    /// <summary>
    /// 设备序列号：正确值为17位长的字符串，前8位 + '-' + 后8位
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
