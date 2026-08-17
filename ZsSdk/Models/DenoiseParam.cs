using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 降噪参数
/// </summary>
public class DenoiseParam
{
    /// <summary>
    /// 降噪模式
    /// </summary>
    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    /// <summary>
    /// 降噪强度
    /// </summary>
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
}
