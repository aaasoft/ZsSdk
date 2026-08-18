using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 通知在线消息请求
/// </summary>
public class ResponseOnlineRequest : BaseRequest, IRequest<ResponseOnlineResponse>
{
    public ResponseOnlineRequest()
    {
        Cmd = "response_online";
    }
}

/// <summary>
/// 通知在线消息响应
/// </summary>
public class ResponseOnlineResponse : BaseResponse
{
}

/// <summary>
/// 主动断开连接消息（服务器主动发送给客户端）
/// </summary>
public class CloseSocketMessage
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "close_socket";

    /// <summary>
    /// 错误码：129应用层异步发送缓慢出现堵包 130应用层写数据时连接断开 131应用层连续出现错误数据断开连接 132应用层接收包数据小于0
    /// </summary>
    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}
