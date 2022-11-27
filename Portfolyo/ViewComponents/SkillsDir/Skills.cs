using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.SkillsDir
{
    public class Skills : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
