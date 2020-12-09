using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        [HttpGet("books")]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            try
            {

            var bookApi =
                RestService.For<IFakeBookApi>("https://my-json-server.typicode.com/a-soltani/aspnetcore-refit");
            var books = (await bookApi.GetBooks()).books;
            return Ok(books);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}