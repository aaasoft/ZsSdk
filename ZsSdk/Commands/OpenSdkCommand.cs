using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 注册OpenSDK监听推送请求
/// </summary>
public class RegisterPushChannelRequest : BaseRequest, IRequest<RegisterPushChannelRequest,RegisterPushChannelResponse>
{
    public RegisterPushChannelRequest()
    {
        Cmd = "register_push_channel";
    }

    [JsonPropertyName("body")]
    public RegisterPushChannelBody? Body { get; set; }
}

/// <summary>
/// 注册OpenSDK监听推送请求体
/// </summary>
public class RegisterPushChannelBody
{
    /// <summary>
    /// 注册openSDK状态，当有推送消息且register_status!=0时，会收到推送消息
    /// </summary>
    [JsonPropertyName("register_status")]
    public int RegisterStatus { get; set; }
}

/// <summary>
/// 注册OpenSDK监听推送响应
/// </summary>
public class RegisterPushChannelResponse : BaseResponse
{
}

/// <summary>
/// OpenSDK推送消息
/// </summary>
public class OpenSdkPushMessage
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "opensdk_push_message";

    [JsonPropertyName("body")]
    public object? Body { get; set; }
}

/// <summary>
/// 请求OpenSDK Push请求
/// </summary>
public class PushMsgToOpenSdkRequest : BaseRequest, IRequest<PushMsgToOpenSdkRequest,PushMsgToOpenSdkResponse>
{
    public PushMsgToOpenSdkRequest()
    {
        Cmd = "push_msg_to_opensdk";
    }

    [JsonPropertyName("body")]
    public object? Body { get; set; }
}

/// <summary>
/// 请求OpenSDK Push响应
/// </summary>
public class PushMsgToOpenSdkResponse : BaseResponse
{
}
