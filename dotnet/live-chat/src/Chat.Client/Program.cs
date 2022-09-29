using Chat.Commands.ClientCommands;
using Chat.Commands.ServerCommands;
using Chat.Client;
using Microsoft.AspNetCore.SignalR.Client;

Console.WriteLine("Connecting to chathub...");

var url = "http://localhost:5229/chatHub";
var username = "user" + new Random().Next(9999);

var connection = new HubConnectionBuilder()
    .WithUrl(url)
    .Build();

connection.Closed += async (error) =>
{
    Console.WriteLine("Connection Closed");
};

await connection.StartAsync();
Console.WriteLine("Connected");
await Task.Delay(1000);

Console.Clear();


//Connection on receive:
connection.OnCommand<ReceiveMessageCommand>((command) => Console.WriteLine($"[{command.TimeStamp.ToString()}] {command.Username}: {command.Text}"));

while (true) {
    string? message = Console.ReadLine();

    if (message is null)
        continue;

    await connection.InvokeCommandAsync(new SendMessageCommand { Username = username, Text = message });
}