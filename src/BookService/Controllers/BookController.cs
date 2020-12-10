using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("books")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var bookApi = RestService.For<IFakeBookApi>("https://my-json-server.typicode.com/a-soltani/aspnetcore-refit");
            var books = await bookApi.GetBooks();

            return Ok(books);
        }
    }
}