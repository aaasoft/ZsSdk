using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置FTP服务启用状态请求
/// </summary>
public class SetVsftpdEnableRequest : BaseRequest, IRequest<SetVsftpdEnableResponse>
{
    public SetVsftpdEnableRequest()
    {
        Cmd = "set_vsftpd_enable";
    }

    [JsonPropertyName("body")]
    public SetVsftpdEnableBody? Body { get; set; }
}

/// <summary>
/// 设置FTP服务启用状态请求体
/// </summary>
public class SetVsftpdEnableBody
{
    /// <summary>
    /// 1:开启；0:关闭
    /// </summary>
    [JsonPropertyName("enable")]
    public int Enable { get; set; }
}

/// <summary>
/// 设置FTP服务启用状态响应
/// </summary>
public class SetVsftpdEnableResponse : BaseResponse
{
}

/// <summary>
/// 获取FTP服务启用状态请求
/// </summary>
public class GetVsftpdEnableRequest : BaseRequest, IRequest<GetVsftpdEnableResponse>
{
    public GetVsftpdEnableRequest()
    {
        Cmd = "get_vsftpd_enable";
    }
}

/// <summary>
/// 获取FTP服务启用状态响应
/// </summary>
public class GetVsftpdEnableResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SetVsftpdEnableBody? Body { get; set; }
}
