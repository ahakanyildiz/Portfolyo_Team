using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.FactDir
{
    public class Facts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
