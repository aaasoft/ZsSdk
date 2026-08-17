using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 加密方式信息
/// </summary>
public class EncryptMethod
{
    /// <summary>
    /// 加密方式的索引
    /// </summary>
    [JsonPropertyName("m_id")]
    public int MId { get; set; }

    /// <summary>
    /// 加密方式的名字
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
