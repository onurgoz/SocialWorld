using Microsoft.AspNetCore.Mvc;
using SocialWorld.Client.Models;

namespace SocialWorld.Client.Controller
{
    public class AuthController : Microsoft.AspNetCore.Mvc.Controller
    {
        public AuthController()
        {
            ViewData["Title"] = "Log in";
        }

        public IActionResult Login()
        {
            
            return View(new LoginModel());
        }

        [HttpPost]
        public IActionResult Login(int a)
        {
            return Ok();
        }
    }
}
