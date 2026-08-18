using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取存储设备信息请求
/// </summary>
public class GetDiskInfoRequest : BaseRequest, IRequest<GetDiskInfoRequest,GetDiskInfoResponse>
{
    public GetDiskInfoRequest()
    {
        Cmd = "get_diskinfo";
    }
}

/// <summary>
/// 获取存储设备信息响应
/// </summary>
public class GetDiskInfoResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public List<DiskInfo>? Body { get; set; }
}
