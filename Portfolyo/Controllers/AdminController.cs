using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;
using Portfolyo.Entites;

namespace Portfolyo.Controllers
{
    public class AdminController : Controller
    {
        MsSqlContext _context = new MsSqlContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Skills()
        {
            var dataList = _context.Skills.ToList();
            return View(dataList);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        //Model Binding
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            //return RedirectToAction("Index","Main"); ==> Farklı bir controllerdaki actiona yönlendirmek istediğimizde bu şekilde kullanırız.
            return RedirectToAction("Skills");
        }
    }
}
