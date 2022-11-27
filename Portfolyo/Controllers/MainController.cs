using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class MainController : Controller
    {
       
        public IActionResult Index()
        {
            var list = new List<string>() { "Büşra", "Abdullah", "Gönül" };
            return View(list);
        }

        public PartialViewResult PartialMenu()
        {
            var list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            return PartialView(list);
        }
    }
}
