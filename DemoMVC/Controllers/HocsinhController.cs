
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HocsinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Hocsinh hs) 
        {
            string strResult = "Xin chào:" + hs.Tenhs + "_" +  hs.Lophs + "_" + hs.Tuoi;
            ViewBag.hfkiu = strResult;
            return View();
        }
        }

   
}