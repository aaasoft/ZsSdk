using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 查找车牌信息请求
/// </summary>
public class SearchPlateRequest : BaseRequest, IRequest<SearchPlateRequest,SearchPlateResponse>
{
    public SearchPlateRequest()
    {
        Cmd = "dg_json_request";
    }

    [JsonPropertyName("body")]
    public SearchPlateBody? Body { get; set; }
}

/// <summary>
/// 查找车牌信息请求体
/// </summary>
public class SearchPlateBody
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "search_plate";

    /// <summary>
    /// 车牌号
    /// </summary>
    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    /// <summary>
    /// 搜索类型：0精确搜索 1模糊搜索
    /// </summary>
    [JsonPropertyName("search_type")]
    public int SearchType { get; set; }
}

/// <summary>
/// 查找车牌信息响应
/// </summary>
public class SearchPlateResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SearchPlateResponseBody? Body { get; set; }
}

/// <summary>
/// 查找车牌信息响应体
/// </summary>
public class SearchPlateResponseBody
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }

    [JsonPropertyName("plate_info")]
    public List<PlateInfo>? PlateInfo { get; set; }
}

/// <summary>
/// 车牌信息
/// </summary>
public class PlateInfo
{
    /// <summary>
    /// 车牌号
    /// </summary>
    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    /// <summary>
    /// 入口时间
    /// </summary>
    [JsonPropertyName("enter_time")]
    public long EnterTime { get; set; }

    /// <summary>
    /// 出口时间
    /// </summary>
    [JsonPropertyName("leave_time")]
    public long LeaveTime { get; set; }

    /// <summary>
    /// 入口设备IP
    /// </summary>
    [JsonPropertyName("enter_ip")]
    public string? EnterIp { get; set; }

    /// <summary>
    /// 出口设备IP
    /// </summary>
    [JsonPropertyName("leave_ip")]
    public string? LeaveIp { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("state")]
    public int State { get; set; }
}
