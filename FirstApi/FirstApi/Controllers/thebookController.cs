using FirstApi.model;
using FirstApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class thebookController : ControllerBase
    {
        private readonly IBooks _books;
        public thebookController(IBooks books)
        {
            _books = books; 
        }

        [HttpGet]  
        public IActionResult GetBooks()
        {
            return Ok(_books.GetBooks());   
        }

        [HttpPost]
        public IActionResult AddBook(Book obj)
        {
            _books.AddBook(obj);
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _books.GetBook(id);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] Book obj)
        {
            if(id == obj.Id)
            {
                _books.UpdateBook(obj);
                return Ok(obj); 
            }
            return NotFound();
        
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var find = _books.GetBook(id);
            if (find != null)
            {
                _books.DeleteBook(id);
                return Ok();
            }
            return NotFound();
    }

    }
}
