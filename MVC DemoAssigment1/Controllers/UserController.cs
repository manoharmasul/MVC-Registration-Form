using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DemoAssigment1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SingUp()
        {
            return View();
        }
    }
}
