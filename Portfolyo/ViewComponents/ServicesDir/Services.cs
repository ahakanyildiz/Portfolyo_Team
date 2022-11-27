using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.ServicesDir
{
    public class Services : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
