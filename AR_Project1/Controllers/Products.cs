using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AR_Project1.Controllers
{
    public class Products : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult BananaView()
        {
            ViewData["Title"] = "香蕉";
            return View();
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult PineappleView()
        {
            ViewData["Title"] = "菠萝";
            return View();
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult DurianView()
        {
            ViewData["Title"] = "榴莲";
            return View();
        }
    }
}
