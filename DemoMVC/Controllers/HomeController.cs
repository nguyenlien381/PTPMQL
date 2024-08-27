using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName )
    {
        string strOutput = "Xin chào" + "-" + FullName;
        ViewBag.hghh = strOutput;
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo(string FullName )
    {
        string strResult = "Hello" + FullName;
        ViewBag.thongbao = strResult;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
