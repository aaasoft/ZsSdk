using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 恢复设备默认配置请求
/// </summary>
public class SetFactoryDefaultRequest : BaseRequest
{
    public SetFactoryDefaultRequest()
    {
        Cmd = "set_factorydefault";
    }

    [JsonPropertyName("body")]
    public SetFactoryDefaultBody? Body { get; set; }
}

/// <summary>
/// 恢复设备默认配置请求体
/// </summary>
public class SetFactoryDefaultBody
{
    /// <summary>
    /// 恢复设备默认值：0完全恢复 1部分恢复
    /// </summary>
    [JsonPropertyName("factorydefault")]
    public int FactoryDefault { get; set; }
}

/// <summary>
/// 恢复设备默认配置响应
/// </summary>
public class SetFactoryDefaultResponse : BaseResponse
{
}
