using ZsSdk;
using ZsSdk.Commands;
// 创建客户端
using var client = new ZsClient("127.0.0.1", 8131);
// 连接设备
await client.ConnectAsync();
// 注册事件
client.OnIvsResult += (sender, result) =>
{
    Console.WriteLine($"识别到车牌: {result.PlateResult?.License}");
};
// 获取序列号
var snResponse = await client.SendRequestAsync<GetSnRequest, GetSnResponse>(
    new GetSnRequest { Id = "123456" });
Console.WriteLine($"设备序列号: {snResponse.Value}");
// 配置识别结果推送
await client.SendRequestAsync<IvsResultRequest, IvsResultResponse>(
    new IvsResultRequest
    {
        Id = "123",
        Enable = true,
        Format = "json",
        Image = true
    });
// 启动消息接收循环
await client.StartReceiveLoopAsync();