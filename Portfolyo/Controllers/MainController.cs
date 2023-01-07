using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;
using Portfolyo.Entites;

namespace Portfolyo.Controllers
{
    public class MainController : Controller
    {
        MsSqlContext context = new MsSqlContext();

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public IActionResult MesajGonder(ContactForm form)
        {
            context?.ContactForms?.Add(form);
            context?.SaveChanges();
            return Redirect("/Main/Index/#contact");
        }
    }
}
