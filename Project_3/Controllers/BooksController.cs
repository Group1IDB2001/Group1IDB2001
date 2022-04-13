using Microsoft.AspNetCore.Mvc;
using Project_3.Managers.Books;

namespace Project_3.Controllers
{
    public class BooksController : Controller
    {
        private IBookManager _manager;

        public BooksController(IBookManager manager)
        {
            _manager = manager;
        }


        public IActionResult Index()
        {
            //var books =
            return View();
        }


    }
}
