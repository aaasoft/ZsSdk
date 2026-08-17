using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 串口参数
/// </summary>
public class SerialParam
{
    /// <summary>
    /// 串口号
    /// </summary>
    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }

    /// <summary>
    /// 波特率
    /// </summary>
    [JsonPropertyName("baud_rate")]
    public int BaudRate { get; set; }

    /// <summary>
    /// 数据位：固定8
    /// </summary>
    [JsonPropertyName("data_bits")]
    public int DataBits { get; set; }

    /// <summary>
    /// 校验位：0无校验 1奇校验 2偶校验
    /// </summary>
    [JsonPropertyName("parity")]
    public int Parity { get; set; }

    /// <summary>
    /// 停止位：1停止位1 2停止位2
    /// </summary>
    [JsonPropertyName("stop_bits")]
    public int StopBits { get; set; }
}
