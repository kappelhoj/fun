using API.Handlers.FetchBooksQuery;
using API.Model;

namespace API.Infrastructure;
public class BookRepository : IBookRepository
{
    public async Task<IEnumerable<Book>> GetBooks()
    {
        return new Book[] {
            new Book { Title = "Title A" },
            new Book { Title = "Title B" } };
    }
}

