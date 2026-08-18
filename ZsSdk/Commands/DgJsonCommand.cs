using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设备组网请求基类
/// </summary>
public class DgJsonRequest : BaseRequest, IRequest<DgJsonResponse>
{
    public DgJsonRequest()
    {
        Cmd = "dg_json_request";
    }

    [JsonPropertyName("body")]
    public DgJsonRequestBody? Body { get; set; }
}

/// <summary>
/// 设备组网请求体
/// </summary>
public class DgJsonRequestBody
{
    /// <summary>
    /// 操作组网模块的命令
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// 设备组网响应
/// </summary>
public class DgJsonResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public DgJsonResponseBody? Body { get; set; }
}

/// <summary>
/// 设备组网响应体
/// </summary>
public class DgJsonResponseBody
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }

    [JsonPropertyName("vzid")]
    public VzId? VzId { get; set; }

    [JsonPropertyName("vzids")]
    public List<VzId>? VzIds { get; set; }

    [JsonPropertyName("online_devices")]
    public List<VzId>? OnlineDevices { get; set; }

    [JsonPropertyName("input_records_size")]
    public int InputRecordsSize { get; set; }

    [JsonPropertyName("output_records_size")]
    public int OutputRecordsSize { get; set; }

    [JsonPropertyName("input_begin_pos")]
    public int InputBeginPos { get; set; }

    [JsonPropertyName("input_end_pos")]
    public int InputEndPos { get; set; }

    [JsonPropertyName("output_records_begin_pos")]
    public int OutputRecordsBeginPos { get; set; }

    [JsonPropertyName("output_records_end_pos")]
    public int OutputRecordsEndPos { get; set; }

    [JsonPropertyName("records")]
    public List<Dictionary<string, object>>? Records { get; set; }

    [JsonPropertyName("group_cfg")]
    public GroupConfig? GroupCfg { get; set; }

    [JsonPropertyName("image_id")]
    public int ImageId { get; set; }

    [JsonPropertyName("image_type")]
    public int ImageType { get; set; }
}

/// <summary>
/// 获取当前设备vzid请求
/// </summary>
public class GetCdvzidRequest : DgJsonRequest
{
    public GetCdvzidRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_cdvzid" };
    }
}

/// <summary>
/// 得到在线设备信息（不含自己）请求
/// </summary>
public class GetOvzidRequest : DgJsonRequest
{
    public GetOvzidRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_ovzid" };
    }
}

/// <summary>
/// 得到在线设备信息（含自己）请求
/// </summary>
public class OnlineDevicesRequest : DgJsonRequest
{
    public OnlineDevicesRequest()
    {
        Body = new DgJsonRequestBody { Type = "online_devices" };
    }
}

/// <summary>
/// 得到所有连接设备信息请求
/// </summary>
public class GetAvzidRequest : DgJsonRequest
{
    public GetAvzidRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_avzid" };
    }
}

/// <summary>
/// 得到当前组网内所有设备信息请求
/// </summary>
public class GetAgdiRequest : DgJsonRequest
{
    public GetAgdiRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_agdi" };
    }
}

/// <summary>
/// 得到当前设备记录size请求
/// </summary>
public class CurrentRecordsSizeRequest : DgJsonRequest
{
    public CurrentRecordsSizeRequest()
    {
        Body = new DgJsonRequestBody { Type = "current_records_size" };
    }
}

/// <summary>
/// 得到入口设备记录请求
/// </summary>
public class RecordsSparateInputRequest : DgJsonRequest
{
    public RecordsSparateInputRequest()
    {
        Body = new RecordsSparateInputBody();
    }
}

/// <summary>
/// 得到入口设备记录请求体
/// </summary>
public class RecordsSparateInputBody : DgJsonRequestBody
{
    public RecordsSparateInputBody()
    {
        Type = "records_sparate_input";
    }

    /// <summary>
    /// 获取记录的开始位置
    /// </summary>
    [JsonPropertyName("input_begin_pos")]
    public int InputBeginPos { get; set; }

    /// <summary>
    /// 获取记录的结束位置
    /// </summary>
    [JsonPropertyName("input_end_pos")]
    public int InputEndPos { get; set; }
}

/// <summary>
/// 得到出口设备记录请求
/// </summary>
public class RecordsSparateOutputRequest : DgJsonRequest
{
    public RecordsSparateOutputRequest()
    {
        Body = new RecordsSparateOutputBody();
    }
}

/// <summary>
/// 得到出口设备记录请求体
/// </summary>
public class RecordsSparateOutputBody : DgJsonRequestBody
{
    public RecordsSparateOutputBody()
    {
        Type = "records_sparate_output";
    }

    /// <summary>
    /// 获取记录的开始位置
    /// </summary>
    [JsonPropertyName("output_records_begin_pos")]
    public int OutputRecordsBeginPos { get; set; }

    /// <summary>
    /// 获取记录的结束位置
    /// </summary>
    [JsonPropertyName("output_records_end_pos")]
    public int OutputRecordsEndPos { get; set; }
}

/// <summary>
/// 使能设备组网请求
/// </summary>
public class EnableDeviceGroupRequest : DgJsonRequest
{
    public EnableDeviceGroupRequest()
    {
        Body = new EnableDeviceGroupBody();
    }
}

/// <summary>
/// 使能设备组网请求体
/// </summary>
public class EnableDeviceGroupBody : DgJsonRequestBody
{
    public EnableDeviceGroupBody()
    {
        Type = "enable_devicegroup";
    }

    [JsonPropertyName("vzid")]
    public VzId? VzId { get; set; }
}

/// <summary>
/// 清除组网数据请求
/// </summary>
public class ResetDatabaseRequest : DgJsonRequest
{
    public ResetDatabaseRequest()
    {
        Body = new DgJsonRequestBody { Type = "reset_database" };
    }
}

/// <summary>
/// 得到当前组网内部所有设备配置请求
/// </summary>
public class GetGroupCfgRequest : DgJsonRequest
{
    public GetGroupCfgRequest()
    {
        Body = new DgJsonRequestBody { Type = "get_group_cfg" };
    }
}

/// <summary>
/// 设置当前组网内部所有设备配置请求
/// </summary>
public class SetGroupCfgRequest : DgJsonRequest
{
    public SetGroupCfgRequest()
    {
        Body = new SetGroupCfgBody();
    }
}

/// <summary>
/// 设置当前组网内部所有设备配置请求体
/// </summary>
public class SetGroupCfgBody : DgJsonRequestBody
{
    public SetGroupCfgBody()
    {
        Type = "set_group_cfg";
    }

    [JsonPropertyName("vzid")]
    public VzId? VzId { get; set; }

    [JsonPropertyName("group_cfg")]
    public List<GroupDeviceConfig>? GroupCfg { get; set; }
}

/// <summary>
/// 根据ID获取组网图片请求
/// </summary>
public class GetImgByIdRequest : DgJsonRequest
{
    public GetImgByIdRequest()
    {
        Body = new GetImgByIdBody();
    }
}

/// <summary>
/// 根据ID获取组网图片请求体
/// </summary>
public class GetImgByIdBody : DgJsonRequestBody
{
    public GetImgByIdBody()
    {
        Type = "get_img_by_id";
    }

    [JsonPropertyName("image_id")]
    public int ImageId { get; set; }

    [JsonPropertyName("image_type")]
    public int ImageType { get; set; }

    [JsonPropertyName("sn")]
    public string? Sn { get; set; }
}
