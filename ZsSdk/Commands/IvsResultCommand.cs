using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 配置推送数据方式请求
/// </summary>
public class IvsResultRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "ivsresult";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 是否允许推送识别结果，默认值：false
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>
    /// 推送识别结果数据格式，默认值：json
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// 识别结果是否包含图片，默认值：true
    /// </summary>
    [JsonPropertyName("image")]
    public bool Image { get; set; } = true;

    /// <summary>
    /// 识别的图片类型，默认值：0
    /// </summary>
    [JsonPropertyName("image_type")]
    public int ImageType { get; set; }
}

/// <summary>
/// 配置推送数据方式响应
/// </summary>
public class IvsResultResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }
}

/// <summary>
/// 获取最近一次识别结果请求
/// </summary>
public class GetIvsResultRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "getivsresult";

    /// <summary>
    /// 是否接收识别结果图片，默认值：false
    /// </summary>
    [JsonPropertyName("image")]
    public bool Image { get; set; }

    /// <summary>
    /// 推送识别结果数据格式，默认值：json
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>
/// 手动触发车牌识别请求
/// </summary>
public class TriggerRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "trigger";
}

/// <summary>
/// 获取记录最大ID请求
/// </summary>
public class GetMaxRecIdRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_max_rec_id";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取记录最大ID响应
/// </summary>
public class GetMaxRecIdResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 识别结果记录中最大的id值
    /// </summary>
    [JsonPropertyName("max_id")]
    public int MaxId { get; set; }
}

/// <summary>
/// 获取历史记录请求
/// </summary>
public class GetRecordRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_record";

    /// <summary>
    /// 识别结果记录的id值
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 推送识别结果数据格式，默认值：json
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// 识别结果是否包含图片，默认值：true
    /// </summary>
    [JsonPropertyName("image")]
    public bool Image { get; set; } = true;
}

/// <summary>
/// 获取记录图片请求
/// </summary>
public class GetImageRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_image";

    /// <summary>
    /// 识别结果记录的id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

/// <summary>
/// 获取记录图片响应
/// </summary>
public class GetImageResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 图片的大小
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }
}

/// <summary>
/// 抓取当前图片请求
/// </summary>
public class GetSnapshotRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_snapshot";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 抓取当前图片响应
/// </summary>
public class GetSnapshotResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 图片格式（jpg）
    /// </summary>
    [JsonPropertyName("imgformat")]
    public string? ImgFormat { get; set; }

    /// <summary>
    /// 图片数据：经过base64转码后的数据
    /// </summary>
    [JsonPropertyName("imgdata")]
    public string? ImgData { get; set; }
}

/// <summary>
/// 获取视频播放URI请求
/// </summary>
public class GetRtspUriRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_rtsp_uri";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取视频播放URI响应
/// </summary>
public class GetRtspUriResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 当前播放视频的URI
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
