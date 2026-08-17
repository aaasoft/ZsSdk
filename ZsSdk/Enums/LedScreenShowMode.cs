namespace ZsSdk.Enums;

/// <summary>
/// 屏显显示模式
/// </summary>
[Flags]
public enum LedScreenShowMode
{
    /// <summary>
    /// 不显示
    /// </summary>
    None = 0x00,

    /// <summary>
    /// 显示用户自定义内容
    /// </summary>
    UserDefine = 0x01,

    /// <summary>
    /// 显示时间
    /// </summary>
    SysTime = 0x02,

    /// <summary>
    /// 显示空余车位
    /// </summary>
    FreeParking = 0x04,

    /// <summary>
    /// 显示车牌号
    /// </summary>
    CarPlate = 0x08,

    /// <summary>
    /// 显示车类型
    /// </summary>
    CarType = 0x10,

    /// <summary>
    /// 显示停车时间
    /// </summary>
    ParkTime = 0x20,

    /// <summary>
    /// 显示收费金额
    /// </summary>
    ChargeMoney = 0x40
}
