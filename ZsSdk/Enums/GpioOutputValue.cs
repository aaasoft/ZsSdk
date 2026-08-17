namespace ZsSdk.Enums;

/// <summary>
/// IO输出状态值
/// </summary>
public enum GpioOutputValue
{
    /// <summary>
    /// 断
    /// </summary>
    Off = 0,

    /// <summary>
    /// 通
    /// </summary>
    On = 1,

    /// <summary>
    /// 先通后断（一般做开闸使用）
    /// </summary>
    Pulse = 2
}
