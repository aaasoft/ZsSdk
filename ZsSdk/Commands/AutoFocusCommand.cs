using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 自动聚焦请求
/// </summary>
public class AutoFocusRequest : BaseRequest, IRequest<AutoFocusRequest, AutoFocusResponse>
{
    public AutoFocusRequest()
    {
        Cmd = "auto_focus";
    }
}

/// <summary>
/// 自动聚焦响应
/// </summary>
public class AutoFocusResponse : BaseResponse
{
}
