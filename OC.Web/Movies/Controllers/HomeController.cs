using Microsoft.AspNetCore.Mvc;
using Movies.ViewModels;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MoviePartViewModel movie)
        {
            var title = movie.Title;
            return View(title);
        }
    }
}
