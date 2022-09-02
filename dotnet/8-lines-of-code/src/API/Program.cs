using API;
using API.Handlers.FetchBooksQuery;
using API.Infrastructure;
using API.Model;

var builder = WebApplication.CreateBuilder(args);

var handlers = new Handler();

handlers.Add((Func<FetchBooksQuery, Task<IReadOnlyCollection<Book>>>)((x) => FetchBooksQuery.Handle(() => new BookRepository(), x)));

var app = builder.Build();

app.MapGet("/", async () =>
    await handlers.HandleAsync<FetchBooksQuery, IReadOnlyCollection<Book>>(new FetchBooksQuery("")));

app.Run();
