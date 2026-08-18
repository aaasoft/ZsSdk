using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 重启设备请求
/// </summary>
public class RebootDevRequest : BaseRequest, IRequest<RebootDevResponse>
{
    public RebootDevRequest()
    {
        Cmd = "reboot_dev";
    }
}

/// <summary>
/// 重启设备响应
/// </summary>
public class RebootDevResponse : BaseResponse
{
}
