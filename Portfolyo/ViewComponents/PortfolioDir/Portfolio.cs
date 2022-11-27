using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.PortfolioDir
{
    public class Portfolio : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
