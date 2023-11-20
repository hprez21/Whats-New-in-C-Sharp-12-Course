using BookerAPI.ProjectData;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController(IBookService service) : ControllerBase
{

    // GET: api/<BooksController>
    [HttpGet]
    public IEnumerable<Book> Get()
    {
        return service.GetBooks();
    }

    // GET api/<BooksController>/5
    [HttpGet("{id}")]
    public Book? Get(int id)
    {
        return service.GetBooks().FirstOrDefault(x => x.Id == id);
    }
}