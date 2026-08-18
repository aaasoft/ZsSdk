using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置用户私有数据请求
/// </summary>
public class SetUserDataRequest : BaseRequest, IRequest<SetUserDataResponse>
{
    public SetUserDataRequest()
    {
        Cmd = "set_user_data";
    }

    [JsonPropertyName("body")]
    public SetUserDataBody? Body { get; set; }
}

/// <summary>
/// 设置用户私有数据请求体
/// </summary>
public class SetUserDataBody
{
    /// <summary>
    /// 需要设置的用户数据，经过base64位编码
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary>
/// 设置用户私有数据响应
/// </summary>
public class SetUserDataResponse : BaseResponse
{
}

/// <summary>
/// 获取用户私有数据请求
/// </summary>
public class GetUserDataRequest : BaseRequest, IRequest<GetUserDataResponse>
{
    public GetUserDataRequest()
    {
        Cmd = "get_user_data";
    }
}

/// <summary>
/// 获取用户私有数据响应
/// </summary>
public class GetUserDataResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SetUserDataBody? Body { get; set; }
}
