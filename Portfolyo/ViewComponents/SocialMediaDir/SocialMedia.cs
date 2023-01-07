using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;

namespace Portfolyo.ViewComponents.SocialMediaDir
{
    public class SocialMedia : ViewComponent
    {
        MsSqlContext context = new MsSqlContext();
        public IViewComponentResult Invoke()
        {
            var data = context?.SocialMedias?.FirstOrDefault(x => x.Id == 1);
            return View(data);
        }
    }
}
