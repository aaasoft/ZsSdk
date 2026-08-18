using System.Text;
using Epoch.net;
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
//     ConnectionTimeoutMs = 5000,    // 连接超时5秒
//     TransportTimeoutMs = 30000     // 传输超时30秒，心跳间隔自动设为10秒
// });

client.OnHeartbeat += (sender, e) =>
{
    Console.CursorLeft = 0;
    Console.Write($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: 收到心跳包");
};

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

// 连接设备
await client.ConnectAsync();
// 获取序列号
{
    var rep = await client.SendRequestAsync(new GetSnRequest());
    if (rep.IsSuccessStatusCode)
        Console.WriteLine($"设备序列号: {rep.Value}");
    else
        Console.WriteLine($"获取设备序列号失败，原因：{rep.StateCode} {rep.ErrorMsg}");
}
// 获取设备时间
{
    var rep = await client.SendRequestAsync(new GetDeviceTimestampRequest());
    if (rep.IsSuccessStatusCode)
        Console.WriteLine($"设备时间: {new EpochTime(rep.Timestamp).DateTime.ToLocalTime():yyyy-MM-dd HH:mm:ss}");
    else
        Console.WriteLine($"获取设备时间失败，原因：{rep.StateCode} {rep.ErrorMsg}");
}
// 配置识别结果推送
{
    var rep = await client.SendRequestAsync(
        new IvsResultRequest
        {
            Enable = true,
            Format = "json",
            Image = true
        });
    if (rep.IsSuccessStatusCode)
        Console.WriteLine($"已配置识别结果推送，等待车牌识别事件...");
    else
        Console.WriteLine($"配置识别结果推送失败，原因：{rep.StateCode} {rep.ErrorMsg}");
}

// 保持程序运行
await Task.Delay(Timeout.Infinite);
