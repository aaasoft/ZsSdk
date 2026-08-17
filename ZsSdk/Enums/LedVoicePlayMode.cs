namespace ZsSdk.Enums;

/// <summary>
/// 语音播放模式
/// </summary>
[Flags]
public enum LedVoicePlayMode
{
    /// <summary>
    /// 不播放语音
    /// </summary>
    None = 0x00,

    /// <summary>
    /// 欢迎语
    /// </summary>
    Welcome = 0x01,

    /// <summary>
    /// 车辆类型
    /// </summary>
    CarType = 0x02,

    /// <summary>
    /// 车牌号
    /// </summary>
    CarPlate = 0x04,

    /// <summary>
    /// 停车时间
    /// </summary>
    ParkTime = 0x08,

    /// <summary>
    /// 收费金额
    /// </summary>
    ChargeMoney = 0x10,

    /// <summary>
    /// 结束语
    /// </summary>
    Tag = 0x20,

    /// <summary>
    /// 自定义语音
    /// </summary>
    UserDefine = 0x40
}
