using API.Requests.CreateOrder;
using FluentValidation;

ValidatorOptions.Global.LanguageManager.Enabled = false;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddScoped<CreateOrderRequestHandler>();

services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();
