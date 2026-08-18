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
    /// 连接超时时间，默认10秒
    /// </summary>
    public TimeSpan ConnectionTimeout { get; set; } = TimeSpan.FromSeconds(10);

    /// <summary>
    /// 传输超时时间（读写操作），默认30秒
    /// </summary>
    public TimeSpan TransportTimeout { get; set; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// 心跳间隔时间，自动设置为传输超时的1/3
    /// </summary>
    public TimeSpan HeartbeatInterval => TimeSpan.FromTicks(TransportTimeout.Ticks / 3);
}
