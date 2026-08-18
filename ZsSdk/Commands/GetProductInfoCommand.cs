using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备版本信息请求
/// </summary>
public class GetProductInfoRequest : BaseRequest, IRequest<GetProductInfoRequest,GetProductInfoResponse>
{
    public GetProductInfoRequest()
    {
        Cmd = "get_product_info";
    }
}

/// <summary>
/// 获取设备版本信息响应
/// </summary>
public class GetProductInfoResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public ProductInfo? Body { get; set; }
}
