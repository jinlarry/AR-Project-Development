using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AR_Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Welcome()
        {
            ViewData["Title"] = "欢迎";

            return View();

        }

        public IActionResult Main()
        {
            ViewData["Title"] = "主页";
            return View();
        }
    }
}
