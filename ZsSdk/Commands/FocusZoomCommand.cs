using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 开始自动聚焦请求
/// </summary>
public class StartFocusAndZoomRequest : BaseRequest, IRequest<StartFocusAndZoomRequest,StartFocusAndZoomResponse>
{
    public StartFocusAndZoomRequest()
    {
        Cmd = "startfocusandzoom";
    }

    [JsonPropertyName("body")]
    public StartFocusAndZoomBody? Body { get; set; }
}

/// <summary>
/// 开始自动聚焦请求体
/// </summary>
public class StartFocusAndZoomBody
{
    /// <summary>
    /// 自动变倍/调焦：0停止 1focus焦增加 2focus焦减小 3zoom变倍增加 4zoom变倍减小
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>
/// 开始自动聚焦响应
/// </summary>
public class StartFocusAndZoomResponse : BaseResponse
{
}

/// <summary>
/// 停止自动聚焦请求
/// </summary>
public class StopFocusAndZoomRequest : BaseRequest, IRequest<StopFocusAndZoomRequest,StopFocusAndZoomResponse>
{
    public StopFocusAndZoomRequest()
    {
        Cmd = "stopfocusandzoom";
    }
}

/// <summary>
/// 停止自动聚焦响应
/// </summary>
public class StopFocusAndZoomResponse : BaseResponse
{
}
