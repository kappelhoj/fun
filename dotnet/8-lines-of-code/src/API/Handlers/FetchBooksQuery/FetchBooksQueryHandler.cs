using API.Model;

namespace API.Handlers.FetchBooksQuery;

public class FetchBooksQueryHandler
{
    public static async Task<IReadOnlyCollection<Book>> Handle(Func<IBookRepository> bookRepositoryFactory, FetchBooksQuery query)
    {
        return new List<Book>() {
            new Book { Title = "Title A" },
            new Book { Title = "Title B" } };
    }
}
