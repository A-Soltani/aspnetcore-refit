using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace BookService.Controllers
{
    public interface IFakeBookApi
    {
        [Get("/db")]
        Task<Root> GetBooks();
    }

    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Root
    {
        public List<Book> books { get; set; }
    }

}