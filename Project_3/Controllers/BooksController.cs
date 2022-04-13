using Microsoft.AspNetCore.Mvc;

namespace Project_3.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
