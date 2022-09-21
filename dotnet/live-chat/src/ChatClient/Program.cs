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
connection.On<ReceiveMessageCommand>(ClientCommandTypes.ReceiveMessage.ToString(), (command) => Console.WriteLine($"[{command.TimeStamp.ToString()}] {command.Username}: {command.Text}"));

await connection.InvokeCommandAsync(new SendMessageCommand { Username = "kappelhoj", Text = "Hello o/"});

await Task.Delay(6000);