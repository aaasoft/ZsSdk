using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取串口参数请求
/// </summary>
public class GetSerialParaRequest : BaseRequest, IRequest<GetSerialParaRequest,GetSerialParaResponse>
{
    public GetSerialParaRequest()
    {
        Cmd = "get_serial_para";
    }

    /// <summary>
    /// 串口号
    /// </summary>
    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }
}

/// <summary>
/// 获取串口参数响应
/// </summary>
public class GetSerialParaResponse : BaseResponse
{
    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }

    [JsonPropertyName("body")]
    public SerialParam? Body { get; set; }
}

/// <summary>
/// 设置串口参数请求
/// </summary>
public class SetSerialParaRequest : BaseRequest, IRequest<SetSerialParaRequest,SetSerialParaResponse>
{
    public SetSerialParaRequest()
    {
        Cmd = "set_serial_para";
    }

    [JsonPropertyName("serial_port")]
    public int SerialPort { get; set; }

    [JsonPropertyName("body")]
    public SerialParam? Body { get; set; }
}

/// <summary>
/// 设置串口参数响应
/// </summary>
public class SetSerialParaResponse : BaseResponse
{
}
