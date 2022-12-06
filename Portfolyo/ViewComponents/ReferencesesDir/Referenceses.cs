using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;

namespace Portfolyo.ViewComponents.ReferencesesDir
{
    public class Referenceses : ViewComponent
    {
        MsSqlContext context = new MsSqlContext();
        public IViewComponentResult Invoke()
        {
            var data = context.References.ToList();
            return View(data);
        }
    }
}
