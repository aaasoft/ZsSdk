using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 注册OpenSDK监听推送请求
/// </summary>
public class RegisterPushChannelRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "register_push_channel";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class RegisterPushChannelResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
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
public class PushMsgToOpenSdkRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "push_msg_to_opensdk";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public object? Body { get; set; }
}

/// <summary>
/// 请求OpenSDK Push响应
/// </summary>
public class PushMsgToOpenSdkResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
