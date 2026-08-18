using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置客户定制SN序列号请求
/// </summary>
public class SetOemSnInfoRequest : BaseRequest, IRequest<SetOemSnInfoResponse>
{
    public SetOemSnInfoRequest()
    {
        Cmd = "set_oem_sn_info";
    }

    [JsonPropertyName("body")]
    public SetOemSnInfoBody? Body { get; set; }
}

/// <summary>
/// 设置客户定制SN序列号请求体
/// </summary>
public class SetOemSnInfoBody
{
    /// <summary>
    /// 客户定制的序列号
    /// </summary>
    [JsonPropertyName("oem_sn")]
    public string? OemSn { get; set; }
}

/// <summary>
/// 设置客户定制SN序列号响应
/// </summary>
public class SetOemSnInfoResponse : BaseResponse
{
}

/// <summary>
/// 获取客户定制SN序列号请求
/// </summary>
public class GetOemSnInfoRequest : BaseRequest, IRequest<GetOemSnInfoResponse>
{
    public GetOemSnInfoRequest()
    {
        Cmd = "get_oem_sn_info";
    }
}

/// <summary>
/// 获取客户定制SN序列号响应
/// </summary>
public class GetOemSnInfoResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SetOemSnInfoBody? Body { get; set; }
}
