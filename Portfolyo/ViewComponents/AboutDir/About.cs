using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.AboutDir
{
    public class About : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
