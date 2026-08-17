using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 操作白名单请求
/// </summary>
public class WhiteListOperatorRequest
{
    [JsonPropertyName("cmd")]
    public string Cmd { get; set; } = "white_list_operator";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 子命令：update_or_add增加或更新 delete删除 select查询
    /// </summary>
    [JsonPropertyName("operator_type")]
    public string? OperatorType { get; set; }

    /// <summary>
    /// 子子命令：plate根据车牌号进行查询
    /// </summary>
    [JsonPropertyName("sub_type")]
    public string? SubType { get; set; }

    /// <summary>
    /// 车牌号
    /// </summary>
    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    /// <summary>
    /// 白名单记录
    /// </summary>
    [JsonPropertyName("dldb_rec")]
    public WhiteListRecord? DldbRec { get; set; }
}

/// <summary>
/// 操作白名单响应
/// </summary>
public class WhiteListOperatorResponse
{
    [JsonPropertyName("cmd")]
    public string? Cmd { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state_code")]
    public int StateCode { get; set; }

    /// <summary>
    /// 子命令
    /// </summary>
    [JsonPropertyName("operator_type")]
    public string? OperatorType { get; set; }

    /// <summary>
    /// 返回结果状态
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 白名单记录列表（查询时返回）
    /// </summary>
    [JsonPropertyName("dldb_rec")]
    public List<WhiteListRecord>? DldbRec { get; set; }
}
