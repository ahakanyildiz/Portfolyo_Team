using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;

namespace Portfolyo.ViewComponents.SkillsDir
{

    public class Skills : ViewComponent
    {
        MsSqlContext _context = new MsSqlContext();

        public IViewComponentResult Invoke()
        {
            var data = _context.Skills.ToList();
            return View(data);
        }
    }
}
