namespace ZsSdk.Enums;

/// <summary>
/// 屏显协议
/// </summary>
public enum Rs485CtrlPro
{
    /// <summary>
    /// 臻识科技识别结果输出协议
    /// </summary>
    ZS_SERIAL = 0x00,

    /// <summary>
    /// 仰绑科技BX5K1控制卡协议
    /// </summary>
    YB_BX5K1 = 0x01,

    /// <summary>
    /// 谐阔EQ系列2013控制卡协议
    /// </summary>
    XQ_EQ2013 = 0x02,

    /// <summary>
    /// 科发LED控制卡协议
    /// </summary>
    KF_LED = 0x03,

    /// <summary>
    /// 方控智能LED控制卡协议
    /// </summary>
    FK_LED = 0x04
}
