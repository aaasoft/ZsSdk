namespace ZsSdk.Models;

/// <summary>
/// 标记请求类型与其响应类型的映射关系
/// </summary>
/// <typeparam name="TResponse">响应类型</typeparam>
public interface IRequest<TResponse> where TResponse : BaseResponse
{
}
