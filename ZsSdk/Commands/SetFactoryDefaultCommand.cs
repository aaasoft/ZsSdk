using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 恢复设备默认配置请求
/// </summary>
public class SetFactoryDefaultRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_factorydefault";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class SetFactoryDefaultResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}
