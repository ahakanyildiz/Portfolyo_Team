using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Portfolyo.Data;
using Portfolyo.Entites;
using Portfolyo.Models;

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


        public IActionResult RemoveSkill(int id)
        {
            var data = _context.Skills.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _context.Skills.Remove(data);
                _context.SaveChanges();
            }

            return RedirectToAction("Skills");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var data = _context.Skills.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }

        public IActionResult References()
        {
            var data = _context.References.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddReferences()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReferences(ReferenceImage refImg)
        {
            var reference = new Reference();
            if (refImg.WriterImage != null)
            {
                var fileName = Path.GetExtension(refImg.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + fileName;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                refImg.WriterImage.CopyTo(stream);
                reference.ImgUrl = newImageName;
            }

            reference.FullName = refImg.FullName;
            reference.Message = refImg.Message;
            reference.Major = refImg.Major;

            _context.References.Add(reference);
            _context.SaveChanges();
            return RedirectToAction("References");
        }
    }
}
