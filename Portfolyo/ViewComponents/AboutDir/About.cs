using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;

namespace Portfolyo.ViewComponents.AboutDir
{
    public class About : ViewComponent
    {
        MsSqlContext _context = new MsSqlContext();
        public IViewComponentResult Invoke()
        {
            var data = _context.Abouts.FirstOrDefault(x=>x.Id==4);
            return View(data);
        }
    }
}
