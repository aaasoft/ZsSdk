using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 语音协议请求基类
/// </summary>
public class PlayserverJsonRequest : BaseRequest, IRequest<PlayserverJsonRequest,PlayserverJsonResponse>
{
    public PlayserverJsonRequest()
    {
        Cmd = "playserver_json_request";
    }

    [JsonPropertyName("body")]
    public PlayserverJsonRequestBody? Body { get; set; }
}

/// <summary>
/// 语音协议请求体
/// </summary>
public class PlayserverJsonRequestBody
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// 语音协议响应
/// </summary>
public class PlayserverJsonResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public PlayserverJsonResponseBody? Body { get; set; }
}

/// <summary>
/// 语音协议响应体
/// </summary>
public class PlayserverJsonResponseBody
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("voice_type")]
    public int VoiceType { get; set; }

    [JsonPropertyName("voice")]
    public List<VoiceFileInfo>? Voice { get; set; }

    [JsonPropertyName("voice_defalut_interval")]
    public int VoiceDefaultInterval { get; set; }

    [JsonPropertyName("voice_defalut_volume")]
    public int VoiceDefaultVolume { get; set; }

    [JsonPropertyName("voice_defalut_male")]
    public int VoiceDefaultMale { get; set; }
}

/// <summary>
/// 获取当前语音文件列表请求
/// </summary>
public class GetVoiceInfoRequest : PlayserverJsonRequest
{
    public GetVoiceInfoRequest()
    {
        Body = new GetVoiceInfoBody();
    }
}

/// <summary>
/// 获取当前语音文件列表请求体
/// </summary>
public class GetVoiceInfoBody : PlayserverJsonRequestBody
{
    public GetVoiceInfoBody()
    {
        Type = "ps_get_voice_info";
    }

    /// <summary>
    /// 文件类型：0未知 1用户语音男声 2用户语音女声 3系统语音男声 4系统语音女声
    /// </summary>
    [JsonPropertyName("voice_type")]
    public int VoiceType { get; set; }
}

/// <summary>
/// 设置语音默认参数请求
/// </summary>
public class SetVoiceConfigRequest : PlayserverJsonRequest
{
    public SetVoiceConfigRequest()
    {
        Body = new SetVoiceConfigBody();
    }
}

/// <summary>
/// 设置语音默认参数请求体
/// </summary>
public class SetVoiceConfigBody : PlayserverJsonRequestBody
{
    public SetVoiceConfigBody()
    {
        Type = "ps_set_voice_config";
    }

    /// <summary>
    /// 语音文件默认播放间隔，单位为毫秒
    /// </summary>
    [JsonPropertyName("voice_defalut_interval")]
    public int VoiceDefaultInterval { get; set; }

    /// <summary>
    /// 语音默认音量，范围为[0,100]
    /// </summary>
    [JsonPropertyName("voice_defalut_volume")]
    public int VoiceDefaultVolume { get; set; }

    /// <summary>
    /// 默认语音类型：0男声 1女声
    /// </summary>
    [JsonPropertyName("voice_defalut_male")]
    public int VoiceDefaultMale { get; set; }
}

/// <summary>
/// 获取语音默认参数请求
/// </summary>
public class GetVoiceConfigRequest : PlayserverJsonRequest
{
    public GetVoiceConfigRequest()
    {
        Body = new PlayserverJsonRequestBody { Type = "ps_get_voice_config" };
    }
}

/// <summary>
/// 播放语音请求
/// </summary>
public class VoicePlayRequest : PlayserverJsonRequest
{
    public VoicePlayRequest()
    {
        Body = new VoicePlayBody();
    }
}

/// <summary>
/// 播放语音请求体
/// </summary>
public class VoicePlayBody : PlayserverJsonRequestBody
{
    public VoicePlayBody()
    {
        Type = "ps_voice_play";
    }

    /// <summary>
    /// 语音信息，utf-8/GBK编码的BASE64编码字符串
    /// </summary>
    [JsonPropertyName("voice")]
    public string? Voice { get; set; }

    /// <summary>
    /// 语音文件播放间隔
    /// </summary>
    [JsonPropertyName("voice_interval")]
    public int VoiceInterval { get; set; }

    /// <summary>
    /// 语音文件音量大小
    /// </summary>
    [JsonPropertyName("voice_volume")]
    public int VoiceVolume { get; set; }

    /// <summary>
    /// 语音类型：0男声 1女声
    /// </summary>
    [JsonPropertyName("voice_male")]
    public int VoiceMale { get; set; }
}

/// <summary>
/// 刷新当前语音文件列表请求
/// </summary>
public class RefreshVoiceInfoRequest : PlayserverJsonRequest
{
    public RefreshVoiceInfoRequest()
    {
        Body = new PlayserverJsonRequestBody { Type = "ps_refresh_voice_info" };
    }
}

/// <summary>
/// 播放指定路径的音频请求
/// </summary>
public class VoicePlayFileRequest : PlayserverJsonRequest
{
    public VoicePlayFileRequest()
    {
        Body = new VoicePlayFileBody();
    }
}

/// <summary>
/// 播放指定路径的音频请求体
/// </summary>
public class VoicePlayFileBody : PlayserverJsonRequestBody
{
    public VoicePlayFileBody()
    {
        Type = "ps_voice_play_file";
    }

    /// <summary>
    /// 1立即播放 0排队播放。默认0
    /// </summary>
    [JsonPropertyName("voice_immediately")]
    public int VoiceImmediately { get; set; }

    /// <summary>
    /// 播放音量，取值范围[1-100]
    /// </summary>
    [JsonPropertyName("voice_volume")]
    public int VoiceVolume { get; set; }

    /// <summary>
    /// 需要播放的音频文件数组-最多10条信息
    /// </summary>
    [JsonPropertyName("voice_file")]
    public List<VoicePlayFile>? VoiceFile { get; set; }
}

/// <summary>
/// 请求语音对讲
/// </summary>
public class StartTalkRequest : BaseRequest, IRequest<StartTalkRequest,StartTalkResponse>
{
    public StartTalkRequest()
    {
        Cmd = "start_talk";
    }

    /// <summary>
    /// 每次发送数据包的大小，建议设置为320
    /// </summary>
    [JsonPropertyName("window_size")]
    public int WindowSize { get; set; }
}

/// <summary>
/// 请求语音对讲响应
/// </summary>
public class StartTalkResponse : BaseResponse
{
    [JsonPropertyName("body")]
    public TalkbackParam? Body { get; set; }
}
