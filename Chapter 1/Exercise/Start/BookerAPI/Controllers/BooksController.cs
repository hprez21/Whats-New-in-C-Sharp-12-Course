using BookerAPI.ProjectData;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController: ControllerBase
{
    IBookService _service;

    public BooksController(IBookService service)
    {
        _service = service;
    }

    // GET: api/<BooksController>
    [HttpGet]
    public IEnumerable<Book> Get()
    {
        return _service.GetBooks();
    }

    // GET api/<BooksController>/5
    [HttpGet("{id}")]
    public Book? Get(int id)
    {
        return _service.GetBooks().FirstOrDefault(x => x.Id == id);
    }
}