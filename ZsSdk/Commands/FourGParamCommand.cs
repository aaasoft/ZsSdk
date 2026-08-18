using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 获取设备4G参数信息请求
/// </summary>
public class Get4GParamRequest : BaseRequest, IRequest<Get4GParamRequest,Get4GParamResponse>
{
    public Get4GParamRequest()
    {
        Cmd = "get_4g_param";
    }
}

/// <summary>
/// 获取设备4G参数信息响应
/// </summary>
public class Get4GParamResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public FourGParam? Body { get; set; }
}

/// <summary>
/// 设置设备4G参数信息请求
/// </summary>
public class Set4GParamRequest : BaseRequest, IRequest<Set4GParamRequest,Set4GParamResponse>
{
    public Set4GParamRequest()
    {
        Cmd = "set_4g_param";
    }

    [JsonPropertyName("body")]
    public Set4GParamBody? Body { get; set; }
}

/// <summary>
/// 设置设备4G参数请求体
/// </summary>
public class Set4GParamBody
{
    /// <summary>
    /// 配置4g参数子命令："set_apn"表示设置apn参数 "set_4g_reset"表示4g重连
    /// </summary>
    [JsonPropertyName("sub_cmd")]
    public string? SubCmd { get; set; }

    /// <summary>
    /// apn参数
    /// </summary>
    [JsonPropertyName("apn_param")]
    public ApnParam? ApnParam { get; set; }
}

/// <summary>
/// APN参数
/// </summary>
public class ApnParam
{
    /// <summary>
    /// apn服务器地址
    /// </summary>
    [JsonPropertyName("apnaddr")]
    public string? ApnAddr { get; set; }

    /// <summary>
    /// apn认证用户名
    /// </summary>
    [JsonPropertyName("username")]
    public string? UserName { get; set; }

    /// <summary>
    /// apn认证密码
    /// </summary>
    [JsonPropertyName("passwd")]
    public string? Passwd { get; set; }

    /// <summary>
    /// apn模式：0不启用 1PAP 2CHAP 3PAP_OR_CHAP
    /// </summary>
    [JsonPropertyName("authentication")]
    public int Authentication { get; set; }
}

/// <summary>
/// 设置设备4G参数信息响应
/// </summary>
public class Set4GParamResponse : BaseResponse
{
}
