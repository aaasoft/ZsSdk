using System.Text;
using ZsSdk;
using ZsSdk.Commands;
using ZsSdk.Models;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// 方式1：使用简化构造函数
using var client = new ZsClient("127.0.0.1", 8131);

// 方式2：使用 ZsClientOptions 配置超时参数
// using var client = new ZsClient(new ZsClientOptions
// {
//     Host = "127.0.0.1",
//     Port = 8131,
//     ConnectionTimeout = TimeSpan.FromSeconds(5),   // 连接超时，同时用于读写超时
//     TransportTimeout = TimeSpan.FromSeconds(30)     // 传输超时，心跳间隔自动设为10秒
// });

// 注册断开连接事件
client.OnDisconnected += (sender, ex) =>
{
    Console.WriteLine($"连接断开: {ex.Message}");
};

// 注册识别结果事件
client.OnIvsResult += (sender, result) =>
{
    Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: 识别到车牌: {result.PlateResult?.License}");
    if (result.FullImg != null)
        File.WriteAllBytes($"FullImg_{DateTime.Now:yyyyMMdd_HHmmss}.jpg", result.FullImg);
    if (result.ClipImg != null)
        File.WriteAllBytes($"ClipImg_{DateTime.Now:yyyyMMdd_HHmmss}.jpg", result.ClipImg);
};

// 连接设备（自动启动后台接收循环和心跳）
await client.ConnectAsync();

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

Console.WriteLine($"已配置识别结果推送，等待车牌识别事件...");

// 保持程序运行
await Task.Delay(Timeout.Infinite);
