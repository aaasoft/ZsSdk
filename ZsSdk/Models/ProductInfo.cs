using System.Text.Json.Serialization;

namespace ZsSdk.Models;

/// <summary>
/// 产品信息
/// </summary>
public class ProductInfo
{
    /// <summary>
    /// Board_version，整数
    /// </summary>
    [JsonPropertyName("boardver")]
    public int BoardVer { get; set; }

    /// <summary>
    /// 软件主版本，整数
    /// </summary>
    [JsonPropertyName("majorver")]
    public int MajorVer { get; set; }

    /// <summary>
    /// Product_ver，字符串，如"RX""RM"
    /// </summary>
    [JsonPropertyName("productver")]
    public string? ProductVer { get; set; }
}
