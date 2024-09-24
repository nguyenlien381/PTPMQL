using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;


namespace DemoMVC.Controllers
{
    public class SinhvienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SinhvienController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sinhvien.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Sinhvien sv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sv);
        }

        
    }
}