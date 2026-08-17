using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 配置透明通道请求
/// </summary>
public class TtransmissionRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "ttransmission";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class TtransmissionResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

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
