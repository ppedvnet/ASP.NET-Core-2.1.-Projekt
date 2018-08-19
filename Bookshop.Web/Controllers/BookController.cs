using Bookshop.Logic.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bookshop.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        [Authorize]
        public IActionResult Index()
        {
            var books = _repo.GetAll();

            return View(books);
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");
        }
    }
}