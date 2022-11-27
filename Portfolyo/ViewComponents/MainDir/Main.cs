using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.MainDir
{
    public class Main : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
