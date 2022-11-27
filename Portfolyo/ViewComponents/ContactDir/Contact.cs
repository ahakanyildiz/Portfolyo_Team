using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.ContactDir
{
    public class Contact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
