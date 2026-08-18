namespace ZsSdk;

/// <summary>
/// ZsClient 配置选项
/// </summary>
public class ZsClientOptions
{
    /// <summary>
    /// 设备IP地址
    /// </summary>
    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// 端口号，默认8131
    /// </summary>
    public int Port { get; set; } = 8131;

    /// <summary>
    /// 连接超时时间（毫秒），默认10000
    /// </summary>
    public int ConnectionTimeoutMs { get; set; } = 10000;

    /// <summary>
    /// 传输超时时间（毫秒），用于读写操作和等待响应，默认30000
    /// </summary>
    public int TransportTimeoutMs { get; set; } = 30000;

    /// <summary>
    /// 心跳间隔时间（毫秒），自动设置为传输超时的1/3
    /// </summary>
    public int HeartbeatIntervalMs => TransportTimeoutMs / 3;
}
