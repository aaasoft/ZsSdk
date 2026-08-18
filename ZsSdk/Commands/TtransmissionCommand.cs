using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 配置透明通道请求
/// </summary>
public class TtransmissionRequest : BaseRequest, IRequest<TtransmissionResponse>
{
    public TtransmissionRequest()
    {
        Cmd = "ttransmission";
    }

    /// <summary>
    /// 子命令：init初始化 uninit取消初始化 send发送数据
    /// </summary>
    [JsonPropertyName("subcmd")]
    public string? SubCmd { get; set; }

    /// <summary>
    /// 数据长度，实际数据长度（即编码前的数据长度）
    /// </summary>
    [JsonPropertyName("datalen")]
    public int DataLen { get; set; }

    /// <summary>
    /// 字符串数据, 经过base64编码后的数据
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// comm口：rs485-1 rs485-2
    /// </summary>
    [JsonPropertyName("comm")]
    public string? Comm { get; set; }
}

/// <summary>
/// 配置透明通道响应
/// </summary>
public class TtransmissionResponse : BaseResponse
{
    /// <summary>
    /// 子命令
    /// </summary>
    [JsonPropertyName("subcmd")]
    public string? SubCmd { get; set; }

    /// <summary>
    /// 返回结果
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}
