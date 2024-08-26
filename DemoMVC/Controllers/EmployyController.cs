using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class EmployyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Employy em)
        {
            string strOutput = "Xin chào:" +  em.Ma + "_" + em.Hoten + "_" + em.Tuoi + "_" + em.Diachi;
            ViewBag.bbh = strOutput;
            return View();
        }
    }
}