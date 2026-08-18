using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置LCD广告音量请求
/// </summary>
public class SetAdVoiceRequest : BaseRequest, IRequest<SetAdVoiceRequest,SetAdVoiceResponse>
{
    public SetAdVoiceRequest()
    {
        Cmd = "set_ad_voice";
    }

    [JsonPropertyName("body")]
    public SetAdVoiceBody? Body { get; set; }
}

/// <summary>
/// 设置LCD广告音量请求体
/// </summary>
public class SetAdVoiceBody
{
    [JsonPropertyName("media_voice_time_ctrl")]
    public List<MediaVoiceTimeCtrl>? MediaVoiceTimeCtrl { get; set; }
}

/// <summary>
/// 设置LCD广告音量响应
/// </summary>
public class SetAdVoiceResponse : BaseResponse
{
}

/// <summary>
/// 查询LCD广告音量请求
/// </summary>
public class GetAdVoiceRequest : BaseRequest, IRequest<GetAdVoiceRequest,GetAdVoiceResponse>
{
    public GetAdVoiceRequest()
    {
        Cmd = "get_ad_voice";
    }
}

/// <summary>
/// 查询LCD广告音量响应
/// </summary>
public class GetAdVoiceResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SetAdVoiceBody? Body { get; set; }
}

/// <summary>
/// 设置LCD背光亮度请求
/// </summary>
public class SetLcdBrightRequest : BaseRequest, IRequest<SetLcdBrightRequest,SetLcdBrightResponse>
{
    public SetLcdBrightRequest()
    {
        Cmd = "set_lcd_bright";
    }

    [JsonPropertyName("body")]
    public SetLcdBrightBody? Body { get; set; }
}

/// <summary>
/// 设置LCD背光亮度请求体
/// </summary>
public class SetLcdBrightBody
{
    [JsonPropertyName("lcd_bright_time_ctrl")]
    public List<LcdBrightTimeCtrl>? LcdBrightTimeCtrl { get; set; }

    /// <summary>
    /// Lcd亮度调节模式0：智能 1：手动-与时间段相关 2关闭屏显
    /// </summary>
    [JsonPropertyName("lcd_bright_mode")]
    public int LcdBrightMode { get; set; }
}

/// <summary>
/// 设置LCD背光亮度响应
/// </summary>
public class SetLcdBrightResponse : BaseResponse
{
}

/// <summary>
/// 查询LCD背光参数请求
/// </summary>
public class GetLcdBrightRequest : BaseRequest, IRequest<GetLcdBrightRequest,GetLcdBrightResponse>
{
    public GetLcdBrightRequest()
    {
        Cmd = "get_lcd_bright";
    }
}

/// <summary>
/// 查询LCD背光参数响应
/// </summary>
public class GetLcdBrightResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public SetLcdBrightBody? Body { get; set; }
}

/// <summary>
/// LCD推送消息请求
/// </summary>
public class AdPushMessageRequest : BaseRequest, IRequest<AdPushMessageRequest,AdPushMessageResponse>
{
    public AdPushMessageRequest()
    {
        Cmd = "ad_push_message";
    }

    [JsonPropertyName("body")]
    public AdPushMessageBody? Body { get; set; }
}

/// <summary>
/// LCD推送消息请求体
/// </summary>
public class AdPushMessageBody
{
    /// <summary>
    /// 要控制的场景名称base64编码
    /// </summary>
    [JsonPropertyName("scene_name")]
    public string? SceneName { get; set; }

    /// <summary>
    /// 收费金额
    /// </summary>
    [JsonPropertyName("parking_fee")]
    public string? ParkingFee { get; set; }

    /// <summary>
    /// 停车时长
    /// </summary>
    [JsonPropertyName("parking_time")]
    public string? ParkingTime { get; set; }

    /// <summary>
    /// 收费状态
    /// </summary>
    [JsonPropertyName("charge_state")]
    public string? ChargeState { get; set; }

    /// <summary>
    /// 动态二维码内容
    /// </summary>
    [JsonPropertyName("qrcode_text")]
    public string? QrcodeText { get; set; }

    /// <summary>
    /// 剩余车位utf-8 base64编码
    /// </summary>
    [JsonPropertyName("parking_space_left")]
    public string? ParkingSpaceLeft { get; set; }

    /// <summary>
    /// 自定义文字utf-8 base64
    /// </summary>
    [JsonPropertyName("custom")]
    public List<string>? Custom { get; set; }
}

/// <summary>
/// LCD推送消息响应
/// </summary>
public class AdPushMessageResponse : BaseResponse
{
}
