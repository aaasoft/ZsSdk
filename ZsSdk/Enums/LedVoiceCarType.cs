namespace ZsSdk.Enums;

/// <summary>
/// 播放语音的车辆类型
/// </summary>
public enum LedVoiceCarType
{
    /// <summary>
    /// 月租车
    /// </summary>
    MonthRent = 1,

    /// <summary>
    /// 临时车
    /// </summary>
    TempCar = 2,

    /// <summary>
    /// 无牌车
    /// </summary>
    NoPlate = 3,

    /// <summary>
    /// 黑名单
    /// </summary>
    Blacklist = 4,

    /// <summary>
    /// 月租车到期
    /// </summary>
    MonthRentExpire = 7,

    /// <summary>
    /// 特殊车
    /// </summary>
    SpecialCar = 9
}
