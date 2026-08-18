using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置GPIO口锁定状态请求
/// </summary>
public class SetIoLockStatusRequest : BaseRequest, IRequest<SetIoLockStatusResponse>
{
    public SetIoLockStatusRequest()
    {
        Cmd = "set_io_lock_status";
    }

    [JsonPropertyName("body")]
    public List<IoLockStatus>? Body { get; set; }
}

/// <summary>
/// IO锁定状态
/// </summary>
public class IoLockStatus
{
    /// <summary>
    /// 输出口 0或者1
    /// </summary>
    [JsonPropertyName("ioout")]
    public int IoOut { get; set; }

    /// <summary>
    /// 0解锁 1高电平锁定 2低电平锁定
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}

/// <summary>
/// 设置GPIO口锁定状态响应
/// </summary>
public class SetIoLockStatusResponse : BaseResponse
{
}

/// <summary>
/// 获取GPIO口锁定状态请求
/// </summary>
public class GetIoLockStatusRequest : BaseRequest, IRequest<GetIoLockStatusResponse>
{
    public GetIoLockStatusRequest()
    {
        Cmd = "get_io_lock_status";
    }
}

/// <summary>
/// 获取GPIO口锁定状态响应
/// </summary>
public class GetIoLockStatusResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public List<IoLockStatus>? Body { get; set; }
}
