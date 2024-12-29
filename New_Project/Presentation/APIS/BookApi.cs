using Microsoft.AspNetCore.Mvc;
using New_Project.Core.Models;
using New_Project.Infrastructure.Iservices;

namespace New_Project.Presentation.APIS
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookAPI : ControllerBase
    {

        private readonly IBookService _services;
        public BookAPI(IBookService userService)
        {
            _services = userService;
        }
        [HttpPost]
        public async Task<object> AddBookAsync([FromBody]Book book)
        {
            var x = await _services.AddBook(book);
            return Ok(x);
        }
        [HttpGet]
        public async Task<object> GetBookSomeAsync([FromHeader]int id)
        {
            var x = await _services.GetSomeBook(id);
            return Ok(x);

        }

        [HttpGet]
        public async Task<object> GetBooksAsync()
        {
            var x = await _services.GetBooks();
            return Ok(x);

        }
        [HttpDelete]
        public async Task<object> DeleteBookAsync([FromHeader] int id)
        {
            var x = await _services.DeleteBook(id);
            if (x != null) { return Ok(); }
            return NotFound();

        }
        [HttpPut]
        public async Task<object> UpdateUserAsync([FromBody] Book book)
        {
            var x = await _services.UpdateBook(book);
            if (x != null) { return Ok(); }
            return NotFound();

        }


    }
}
