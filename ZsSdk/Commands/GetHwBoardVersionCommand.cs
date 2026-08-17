using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备硬件版本信息请求
/// </summary>
public class GetHwBoardVersionRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_hw_board_version";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取设备硬件版本信息响应
/// </summary>
public class GetHwBoardVersionResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("body")]
    public HardwareVersion? Body { get; set; }
}
