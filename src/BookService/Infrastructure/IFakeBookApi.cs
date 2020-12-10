using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace BookService.Controllers
{
    public interface IFakeBookApi
    {
        [Get("/db")]
        Task<IEnumerable<Book>> GetBooks();
    }
}