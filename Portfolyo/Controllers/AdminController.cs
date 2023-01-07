using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;
using Portfolyo.Entites;

namespace Portfolyo.Controllers
{
    [Authorize(Roles = "Admin")] // Controller bazında Authorize
    public class AdminController : Controller
    {
        MsSqlContext _context = new MsSqlContext();

        public IActionResult Index()
        {
            return View();
        }

       // [Authorize(Roles ="Admin")] //Method bazında Authorize
        [HttpGet]
        public IActionResult Skills()
        {
            var dataList = _context?.Skills?.ToList();

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
            _context?.Skills?.Add(skill);
            _context?.SaveChanges();
            //return RedirectToAction("Index","Main"); ==> Farklı bir controllerdaki actiona yönlendirmek istediğimizde bu şekilde kullanırız.
            return RedirectToAction("Skills");
        }


        public IActionResult RemoveSkill(int id)
        {
            var data = _context?.Skills.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _context?.Skills?.Remove(data);
                _context.SaveChanges();
            }

            return RedirectToAction("Skills");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var data = _context?.Skills?.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _context?.Skills?.Update(skill);
            _context?.SaveChanges();
            return RedirectToAction("Skills");
        }

        public IActionResult References()
        {
            var data = _context?.References?.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddReferences()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReferences(Reference entity, IFormFile imgFile)
        {
            if (imgFile != null)
            {
                var fileName = Path.GetExtension(imgFile.FileName); // Uzantısı (jpg,png,ico)
                var newImageName = Guid.NewGuid() + fileName; // Guid bulunduğumuz zamana bağlı benzersiz bir key oluşturur.
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                imgFile.CopyTo(stream);
                entity.ImgUrl = newImageName;
            }

            _context?.References?.Add(entity);
            _context?.SaveChanges();
            return RedirectToAction("References");
        }


        [HttpGet]
        public IActionResult EditReference(int id)
        {
            var reference = _context.References.FirstOrDefault(x => x.Id == id);

            if (reference != null)
            {
                return View(reference);
            }

            else
            {
                return RedirectToAction("References");
            }
        }

        [HttpPost]
        public IActionResult updateRef(Reference entity, IFormFile imgFile)
        {
            if (imgFile != null)
            {
                var fileName = Path.GetExtension(imgFile.FileName); // Uzantısı (jpg,png,ico)
                var newImageName = Guid.NewGuid() + fileName; // Guid bulunduğumuz zamana bağlı benzersiz bir key oluşturur.
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                imgFile.CopyTo(stream);
                entity.ImgUrl = newImageName;
            }

            _context?.References?.Update(entity);
            _context?.SaveChanges();
            return RedirectToAction("References");
        }

        public IActionResult DeleteReference(int id)
        {
            var reference = _context.References.FirstOrDefault(x => x.Id == id);

            if (reference != null)
            {
                _context.References.Remove(reference);
                _context?.SaveChanges();   
            }

            return RedirectToAction("References");
        }
    }
}
