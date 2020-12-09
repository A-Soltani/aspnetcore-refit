using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        [HttpGet("books")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = new List<Book>();

            return Ok(books);
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}