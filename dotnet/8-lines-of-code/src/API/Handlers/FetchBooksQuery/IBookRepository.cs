using API.Model;
using System.Collections.Generic;

namespace API.Handlers.FetchBooksQuery;
public interface IBookRepository
{
    public Task<IEnumerable<Book>> GetBooks();

}
