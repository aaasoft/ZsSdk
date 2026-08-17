namespace ZsSdk.Enums;

/// <summary>
/// 触发类型
/// </summary>
public enum TriggerType
{
    /// <summary>
    /// 自动识别触发
    /// </summary>
    Auto = 1,

    /// <summary>
    /// 外部输入触发（IO）
    /// </summary>
    ExternalIO = 2,

    /// <summary>
    /// 软件触发(SDK)
    /// </summary>
    Software = 4,

    /// <summary>
    /// 虚拟线圈触发
    /// </summary>
    VirtualLoop = 8,

    /// <summary>
    /// 车滞留事件
    /// </summary>
    CarStay = 64,

    /// <summary>
    /// 车滞留恢复事件
    /// </summary>
    CarStayRecover = 65
}
