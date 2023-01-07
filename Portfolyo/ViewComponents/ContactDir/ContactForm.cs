using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.ContactDir
{
    public class ContactForm : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
