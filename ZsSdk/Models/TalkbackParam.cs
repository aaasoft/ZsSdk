using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 语音对讲参数
/// </summary>
public class TalkbackParam
{
    /// <summary>
    /// 支持的编码类型：1.PCM 2.G711 3.G711A
    /// </summary>
    [JsonPropertyName("encode_type")]
    public int EncodeType { get; set; }

    /// <summary>
    /// 语音对讲通信TCP服务端口
    /// </summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>
    /// 对讲状态：0空闲 1忙碌
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 采样率固定值8000(默认)|16000
    /// </summary>
    [JsonPropertyName("sampling_rate")]
    public int SamplingRate { get; set; }

    /// <summary>
    /// 每次发送数据包的大小
    /// </summary>
    [JsonPropertyName("window_size")]
    public int WindowSize { get; set; }

    /// <summary>
    /// 采样点，固定值512
    /// </summary>
    [JsonPropertyName("sample_point")]
    public int SamplePoint { get; set; }
}
