using System.Collections.Generic;
using System.Threading.Tasks;
using BookService.Controllers;
using Refit;

namespace BookService.Infrastructure
{
    public interface IFakeBookApi
    {
        [Get("/db")]
        Task<Result> GetBooks();
    }

    public class Result
    {
        public IEnumerable<Book> Books { get; set; }
    }
}