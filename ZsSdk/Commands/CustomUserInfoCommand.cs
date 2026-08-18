using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取自定义信息请求
/// </summary>
public class GetCustomUserInfoRequest : BaseRequest, IRequest<GetCustomUserInfoResponse>
{
    public GetCustomUserInfoRequest()
    {
        Cmd = "get_custom_user_info";
    }
}

/// <summary>
/// 获取自定义信息响应
/// </summary>
public class GetCustomUserInfoResponse : BaseResponse
{
    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; set; }

    [JsonPropertyName("body")]
    public CustomUserInfo? Body { get; set; }
}

/// <summary>
/// 设置用户自定义信息请求
/// </summary>
public class SetCustomUserInfoRequest : BaseRequest, IRequest<SetCustomUserInfoResponse>
{
    public SetCustomUserInfoRequest()
    {
        Cmd = "set_custom_user_info";
    }

    [JsonPropertyName("body")]
    public CustomUserInfo? Body { get; set; }
}

/// <summary>
/// 设置用户自定义信息响应
/// </summary>
public class SetCustomUserInfoResponse : BaseResponse
{
}
