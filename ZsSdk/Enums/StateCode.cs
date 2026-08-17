namespace ZsSdk.Enums;

/// <summary>
/// 状态码定义
/// </summary>
public enum StateCode
{
    /// <summary>
    /// 请求的命令执行成功
    /// </summary>
    Success = 200,

    /// <summary>
    /// 客户端请求出错（因为错误的语法导致服务器无法理解请求信息）
    /// </summary>
    BadRequest = 400,

    /// <summary>
    /// 客户没有权限，请求需要用户验证
    /// </summary>
    Unauthorized = 401,

    /// <summary>
    /// 请求的资源不存在
    /// </summary>
    NotFound = 404,

    /// <summary>
    /// 请求的命令不存在
    /// </summary>
    MethodNotAllowed = 405,

    /// <summary>
    /// 请求超时
    /// </summary>
    RequestTimeout = 408,

    /// <summary>
    /// 服务器内部错误
    /// </summary>
    InternalServerError = 500
}
