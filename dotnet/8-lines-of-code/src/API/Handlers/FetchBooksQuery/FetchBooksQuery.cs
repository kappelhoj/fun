using API.Model;

namespace API.Handlers.FetchBooksQuery;

public record FetchBooksQuery(string Search)
{
    public static async Task<IReadOnlyCollection<Book>> Handle(
        Func<IBookRepository> bookRepositoryFactory, 
        FetchBooksQuery query)
    {

        var books = await bookRepositoryFactory().GetBooks();
        return books.ToArray();
    }
}

