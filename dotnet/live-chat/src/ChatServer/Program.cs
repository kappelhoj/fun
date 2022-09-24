using ChatServer;
using ChatServer.Clients;
using ChatServer.Handlers;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddSignalR();
services.AddTransient<SendMessageHandler>();
services.AddTransient<ClientBroadcaster>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("/chatHub");

app.Run();
