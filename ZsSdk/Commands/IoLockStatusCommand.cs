using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置GPIO口锁定状态请求
/// </summary>
public class SetIoLockStatusRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_io_lock_status";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class SetIoLockStatusResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }
}

/// <summary>
/// 获取GPIO口锁定状态请求
/// </summary>
public class GetIoLockStatusRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_io_lock_status";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取GPIO口锁定状态响应
/// </summary>
public class GetIoLockStatusResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("body")]
    public List<IoLockStatus>? Body { get; set; }
}
