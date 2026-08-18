using System.Text.Json.Serialization;
using ZsSdk.Models;

namespace ZsSdk.Commands;

/// <summary>
/// 设置当前配置为用户默认配置请求
/// </summary>
public class SetUserDefaultCfgRequest : BaseRequest, IRequest<SetUserDefaultCfgResponse>
{
    public SetUserDefaultCfgRequest()
    {
        Cmd = "set_user_default_cfg";
    }
}

/// <summary>
/// 设置当前配置为用户默认配置响应
/// </summary>
public class SetUserDefaultCfgResponse : BaseResponse
{
}
