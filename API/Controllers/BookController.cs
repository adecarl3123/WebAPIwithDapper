using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using ProjectName.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        BookService bookServices = new BookService();

        [HttpGet]
        public ActionResult GetAll()
        {
            var book = bookServices.GetAll();
            return Ok(book);
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            return bookServices.GetById(id);
        }

        [HttpPost]
        public bool Add(Book book)
        {
            return bookServices.Add(book);
        }
        
        [HttpPut]
        public bool Update(Book book)
        {
            return bookServices.Updatet(book);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return bookServices.Delete(id);
        }





    }
}
