using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student st)
        {
            string strOutput = "Xin chào" + st.StudentId +  "-" + st.FullName;
            ViewBag.tyh = strOutput;
            return View();
        }
    }
}