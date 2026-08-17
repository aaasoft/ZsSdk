using System.Text.Json.Serialization;

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
public class IoctlRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "ioctl";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class IoctlResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 获取IO输入状态请求
/// </summary>
public class GetGpioValueRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_gpio_value";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 对应的输入IO编号
    /// </summary>
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }
}

/// <summary>
/// 获取IO输入状态响应
/// </summary>
public class GetGpioValueResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

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
public class GetGpioOutValueRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_gpio_out_value";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 对应的输入IO编号
    /// </summary>
    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }
}

/// <summary>
/// 获取IO输出状态响应
/// </summary>
public class GetGpioOutValueResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("gpio")]
    public int Gpio { get; set; }

    /// <summary>
    /// 输出IO的状态值：0低电平 1高电平
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}
