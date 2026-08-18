using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设备端主动推送GPIO输入状态消息
/// </summary>
public class GpioTriggerMessage
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "gpio_trigger";

    /// <summary>
    /// 对应的输出IO编号
    /// </summary>
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }

    /// <summary>
    /// 输入状态：0低电平 1高电平
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>
/// 控制IO输出请求
/// </summary>
public class IoctlRequest : BaseRequest, IRequest<IoctlResponse>
{
    public IoctlRequest()
    {
        Cmd = "ioctl";
    }

    /// <summary>
    /// 对应的输出IO编号
    /// </summary>
    [JsonPropertyName("io")]
    public int Io { get; set; }

    /// <summary>
    /// 输出IO的状态值：0断 1通 2先通后断
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }

    /// <summary>
    /// 先通后断的延迟时间
    /// </summary>
    [JsonPropertyName("delay")]
    public int Delay { get; set; }
}

/// <summary>
/// 控制IO输出响应
/// </summary>
public class IoctlResponse : BaseResponse
{
}

/// <summary>
/// 获取IO输入状态请求
/// </summary>
public class GetGpioValueRequest : BaseRequest, IRequest<GetGpioValueResponse>
{
    public GetGpioValueRequest()
    {
        Cmd = "get_gpio_value";
    }

    /// <summary>
    /// 对应的输入IO编号
    /// </summary>
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }
}

/// <summary>
/// 获取IO输入状态响应
/// </summary>
public class GetGpioValueResponse : BaseResponse
{
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }

    /// <summary>
    /// 输入IO的状态值：0低电平 1高电平
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>
/// 获取IO输出状态请求
/// </summary>
public class GetGpioOutValueRequest : BaseRequest, IRequest<GetGpioOutValueResponse>
{
    public GetGpioOutValueRequest()
    {
        Cmd = "get_gpio_out_value";
    }

    /// <summary>
    /// 对应的输入IO编号
    /// </summary>
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }
}

/// <summary>
/// 获取IO输出状态响应
/// </summary>
public class GetGpioOutValueResponse : BaseResponse
{
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }

    /// <summary>
    /// 输出IO的状态值：0低电平 1高电平
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}
