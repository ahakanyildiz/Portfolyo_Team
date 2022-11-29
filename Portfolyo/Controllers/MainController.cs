using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class MainController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialMenu()
        {     
            return PartialView();
        }
    }
}
