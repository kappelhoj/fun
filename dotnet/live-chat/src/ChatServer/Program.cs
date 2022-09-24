using ChatServer;
using ChatServer.Handlers;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddSignalR();
services.AddTransient<SendMessageHandler>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("/chatHub");

app.Run();
