using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PhanphoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Phanphoi php)
        {
            string strOutput = "Hello" + ":" + php.Nhaphanphoi + "_" + php.Maphanphoi;
            ViewBag.tb = strOutput;
            return View();
        }
    }
}