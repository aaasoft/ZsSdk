using System.Text;
using ZsSdk;
using ZsSdk.Commands;
using ZsSdk.Models;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// 创建客户端
using var client = new ZsClient("127.0.0.1", 8131);
// 连接设备
await client.ConnectAsync();
// 注册事件
client.OnIvsResult += (sender, result) =>
{
    Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: 识别到车牌: {result.PlateResult?.License}");
    if(result.FullImg!=null)
        File.WriteAllBytes($"FullImg_{DateTime.Now:yyyyMMdd_HHmmss}.jpg",result.FullImg);
    if(result.ClipImg!=null)
        File.WriteAllBytes($"ClipImg_{DateTime.Now:yyyyMMdd_HHmmss}.jpg",result.ClipImg);
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

Console.WriteLine($"启动消息接收循环");
//发送心跳包
_ = Task.Delay(1000).ContinueWith(async t =>
{
    //用上一次识别来触发
    await client.SendRequestAsync(new GetIvsResultRequest()
    {
        Format = "json",
        Image = true
    });
    while (true)
    {
        await Task.Delay(5000);
        await client.SendHeartbeatAsync();
    }
});
// 启动消息接收循环
await client.StartReceiveLoopAsync();