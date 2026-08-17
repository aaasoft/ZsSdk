using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取存储设备信息请求
/// </summary>
public class GetDiskInfoRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_diskinfo";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取存储设备信息响应
/// </summary>
public class GetDiskInfoResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("body")]
    public List<DiskInfo>? Body { get; set; }
}
