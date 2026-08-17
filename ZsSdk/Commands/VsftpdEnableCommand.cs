using System.Text.Json.Serialization;

namespace ZsSdk.Commands;

/// <summary>
/// 设置FTP服务启用状态请求
/// </summary>
public class SetVsftpdEnableRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "set_vsftpd_enable";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
public class SetVsftpdEnableResponse
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
/// 获取FTP服务启用状态请求
/// </summary>
public class GetVsftpdEnableRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "get_vsftpd_enable";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// 获取FTP服务启用状态响应
/// </summary>
public class GetVsftpdEnableResponse
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
    public SetVsftpdEnableBody? Body { get; set; }
}
