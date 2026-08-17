using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取串口参数请求
/// </summary>
public class GetSerialParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_serial_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 串口号
    /// </summary>
    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }
}

/// <summary>
/// 获取串口参数响应
/// </summary>
public class GetSerialParaResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public SerialParam? Body { get; set; }
}

/// <summary>
/// 设置串口参数请求
/// </summary>
public class SetSerialParaRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_serial_para";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }

    [JsonPropertyName("body")]
    public SerialParam? Body { get; set; }
}

/// <summary>
/// 设置串口参数响应
/// </summary>
public class SetSerialParaResponse
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
