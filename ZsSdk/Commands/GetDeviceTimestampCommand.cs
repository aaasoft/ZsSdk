using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备当前时间戳请求
/// </summary>
public class GetDeviceTimestampRequest : BaseRequest, IRequest<GetDeviceTimestampResponse>
{
    public GetDeviceTimestampRequest()
    {
        Cmd = "get_device_timestamp";
    }
}

/// <summary>
/// 获取设备当前时间戳响应
/// </summary>
public class GetDeviceTimestampResponse : BaseResponse
{
    /// <summary>
    /// 时间（格林威治时间，单位秒）
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
}
