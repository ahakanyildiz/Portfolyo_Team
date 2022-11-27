using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.ResumeDir
{
    public class Resume : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
