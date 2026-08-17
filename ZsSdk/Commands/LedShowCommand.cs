using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置LED显示内容请求
/// </summary>
public class SetLedShowRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_led_show";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public LedShowConfig? Body { get; set; }
}

/// <summary>
/// 设置LED显示内容响应
/// </summary>
public class SetLedShowResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 获取LED显示内容请求
/// </summary>
public class GetLedShowRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_led_show";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取LED显示内容响应
/// </summary>
public class GetLedShowResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public LedShowConfig? Body { get; set; }
}

/// <summary>
/// 获取LED数据传输使用串口号请求
/// </summary>
public class GetLedSerialPortRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_led_serial_port";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取LED数据传输使用串口号响应
/// </summary>
public class GetLedSerialPortResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 使用的串口号（1,2，部分设备支持3）
    /// </summary>
    [JsonPropertyName("use_serial_port")]
    public int UseSerialPort { get; set; }
}

/// <summary>
/// 设置LED数据传输使用串口号请求
/// </summary>
public class SetLedSerialPortRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_led_serial_port";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("body")]
    public SetLedSerialPortBody? Body { get; set; }
}

/// <summary>
/// 设置LED数据传输使用串口号请求体
/// </summary>
public class SetLedSerialPortBody
{
    /// <summary>
    /// 使用的串口号（1,2，部分设备支持3）
    /// </summary>
    [JsonPropertyName("use_serial_port")]
    public int UseSerialPort { get; set; }
}

/// <summary>
/// 设置LED数据传输使用串口号响应
/// </summary>
public class SetLedSerialPortResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
