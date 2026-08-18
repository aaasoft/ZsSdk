using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置LED显示内容请求
/// </summary>
public class SetLedShowRequest : BaseRequest, IRequest<SetLedShowResponse>
{
    public SetLedShowRequest()
    {
        Cmd = "set_led_show";
    }

    [JsonPropertyName("body")]
    public LedShowConfig? Body { get; set; }
}

/// <summary>
/// 设置LED显示内容响应
/// </summary>
public class SetLedShowResponse : BaseResponse
{
}

/// <summary>
/// 获取LED显示内容请求
/// </summary>
public class GetLedShowRequest : BaseRequest, IRequest<GetLedShowResponse>
{
    public GetLedShowRequest()
    {
        Cmd = "get_led_show";
    }
}

/// <summary>
/// 获取LED显示内容响应
/// </summary>
public class GetLedShowResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public LedShowConfig? Body { get; set; }
}

/// <summary>
/// 获取LED数据传输使用串口号请求
/// </summary>
public class GetLedSerialPortRequest : BaseRequest, IRequest<GetLedSerialPortResponse>
{
    public GetLedSerialPortRequest()
    {
        Cmd = "get_led_serial_port";
    }
}

/// <summary>
/// 获取LED数据传输使用串口号响应
/// </summary>
public class GetLedSerialPortResponse : BaseResponse
{
    /// <summary>
    /// 使用的串口号（1,2，部分设备支持3）
    /// </summary>
    [JsonPropertyName("use_serial_port")]
    public int UseSerialPort { get; set; }
}

/// <summary>
/// 设置LED数据传输使用串口号请求
/// </summary>
public class SetLedSerialPortRequest : BaseRequest, IRequest<SetLedSerialPortResponse>
{
    public SetLedSerialPortRequest()
    {
        Cmd = "set_led_serial_port";
    }

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
public class SetLedSerialPortResponse : BaseResponse
{
}
