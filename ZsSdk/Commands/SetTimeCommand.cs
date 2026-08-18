using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置系统时间请求
/// </summary>
public class SetTimeRequest : BaseRequest, IRequest<SetTimeRequest,SetTimeResponse>
{
    public SetTimeRequest()
    {
        Cmd = "set_time";
    }

    /// <summary>
    /// 时间字符串，格式必须是："XXXX-XX-XX XX:XX:XX"
    /// </summary>
    [JsonPropertyName("timestring")]
    public string? TimeString { get; set; }
}

/// <summary>
/// 设置系统时间响应
/// </summary>
public class SetTimeResponse : BaseResponse
{
}
