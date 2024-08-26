
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xinchao:" +  ps.PersonId + "_" + ps.FullName +"_" + ps.Address;
            ViewBag.fgjk = strOutput;
            return View();
        }

    }
}