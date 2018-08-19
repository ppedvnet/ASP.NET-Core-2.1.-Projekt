using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Bookshop.Logic.Contracts;

namespace Bookshop.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult GetAll()
        {
            var books = _repo.GetAll();

            return Ok(books);
        }
    }
}