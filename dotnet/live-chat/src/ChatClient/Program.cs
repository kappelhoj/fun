using Chat.Commands;
using Chat.Commands.ClientCommands;
using Chat.Commands.ServerCommands;
using ChatClient;
using Microsoft.AspNetCore.SignalR.Client;

Console.WriteLine("Hello, World!");
Console.WriteLine("Connecting to chathub");

var url = "http://localhost:5229/chatHub";

var connection = new HubConnectionBuilder()
    .WithUrl(url)
    .Build();


connection.Closed += async (error) =>
{
    Console.WriteLine("Connection Closed");
};

await connection.StartAsync();

//Connection on receive:
connection.OnCommand<ReceiveMessageCommand>((command) => Console.WriteLine($"[{command.TimeStamp.ToString()}] {command.Username}: {command.Text}"));


await connection.InvokeCommandAsync(new SendMessageCommand { Username = "kappelhoj", Text = "Hello o/"});
await connection.InvokeCommandAsync(new SendMessageCommand { Username = "fava", Text = "Hello \\o"});
await connection.InvokeCommandAsync(new SendMessageCommand { Username = "kappelhoj", Text = "How are you doing?"});
await connection.InvokeCommandAsync(new SendMessageCommand { Username = "fava", Text = "Not to bad."});
await connection.InvokeCommandAsync(new SendMessageCommand { Username = "kappelhoj", Text = "Ok"});

await Task.Delay(6000);