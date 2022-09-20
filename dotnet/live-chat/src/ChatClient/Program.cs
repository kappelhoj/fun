// See https://aka.ms/new-console-template for more information
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
connection.On<string, string>("ReceiveMessage", (user,message) => Console.WriteLine($"{user}: {message}"));

await connection.InvokeAsync("Sendmessage", "kappelhoj", "Hello server!");

