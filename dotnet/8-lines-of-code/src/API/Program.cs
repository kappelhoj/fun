using API;
using API.Handlers.FetchBooksQuery;
using API.Infrastructure;
using API.Model;

var builder = WebApplication.CreateBuilder(args);

var handlers = new Handler();

handlers.Add<FetchBooksQuery, IReadOnlyCollection<Book>>((x) => FetchBooksQueryHandler.Handle(() => new BookRepository(), x));

var app = builder.Build();

app.MapGet("/",  (httpContext) =>
    Task.FromResult(handlers.Handle<FetchBooksQuery, IReadOnlyCollection<Book>>(new FetchBooksQuery(""))));

app.Run();
