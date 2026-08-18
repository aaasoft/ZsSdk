using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备硬件版本信息请求
/// </summary>
public class GetHwBoardVersionRequest : BaseRequest, IRequest<GetHwBoardVersionRequest,GetHwBoardVersionResponse>
{
    public GetHwBoardVersionRequest()
    {
        Cmd = "get_hw_board_version";
    }
}

/// <summary>
/// 获取设备硬件版本信息响应
/// </summary>
public class GetHwBoardVersionResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public HardwareVersion? Body { get; set; }
}
