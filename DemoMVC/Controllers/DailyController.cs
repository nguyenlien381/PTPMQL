using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DailyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Daily dl)
        {
            string strOutput = dl.MaDaily + "_" + dl.TenDaily + "_" + dl.Diachi + "_" + dl.NguoiDaidien + "_" + dl.Dienthoai;
            ViewBag.ghj = strOutput;
            return View();
        }
    }
}