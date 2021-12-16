using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialWorld.Client.Controller
{
    public class AuthController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Login()
        {

            return View();
        }
    }
}
