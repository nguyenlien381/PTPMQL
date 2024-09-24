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
        public async Task<IActionResult> Create([Bind("Masv,Tensv,Daichi")]Sinhvien sv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sv);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sv = await _context.Sinhvien.FindAsync(id);
            if (sv == null)
            {
                return NotFound();
            }
            return View(sv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string Masv, [Bind("Masv,Tensv,Daichi")] Sinhvien sv)
        {
            if (Masv != sv.Masv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhvienExists(sv.Masv))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sv);
        }
        public async Task<IActionResult> Delete(string Masv)
        {
            if (Masv == null)
            {
                return NotFound();
            }

            var sv = await _context.Sinhvien
                .FirstOrDefaultAsync(m => m.Masv == Masv);
            if (sv == null)
            {
                return NotFound();
            }

            return View(sv);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string Masv)
        {
            var sv = await _context.Sinhvien.FindAsync(Masv);
            if (Masv != null)
            {
                _context.Sinhvien.Remove(sv);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinhvienExists(string Masv)
        {
            return _context.Sinhvien.Any(e => e.Masv == Masv);
        }
        
    }
}