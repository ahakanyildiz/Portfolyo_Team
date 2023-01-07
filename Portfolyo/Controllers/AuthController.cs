using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Data;
using Portfolyo.Entites;
using System.Security.Claims;
using Portfolyo.Enums;

namespace Portfolyo.Controllers
{
    public class AuthController : Controller //Auth dememin sebebi Authantication yani login sisteminden gelmesi.
    {
        MsSqlContext _context = new MsSqlContext();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUser entity)
        {
            var loginUser = _context.AppUsers.FirstOrDefault(x => x.Username == entity.Username && x.Password == entity.Password && entity.AppRoleId==(int)RoleTypes.Admin);

          
            if (loginUser != null)
            {
                //User => 
                var claimsList = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginUser.Username),
                    new Claim(ClaimTypes.NameIdentifier,loginUser.Id.ToString()),
                    new Claim(ClaimTypes.Role,Enum.GetName(typeof(RoleTypes),loginUser.AppRoleId)), //Veritabanından Role Bilgisi için Role tablosunda sorgulama yapmak yerine Enum nimetini kullanarak bu işi gerçekleştirdim.
                };

                var claimsIdentity = new ClaimsIdentity(
                    claimsList, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                   
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("Index","Admin");
            }

            ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış!");
            return View(entity);
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Admin");
        }
    }
}
