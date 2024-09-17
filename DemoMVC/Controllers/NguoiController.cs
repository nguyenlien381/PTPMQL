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
    public class NguoiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguoiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nguoi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nguoi.ToListAsync());
        }

        // GET: Nguoi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoi = await _context.Nguoi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoi == null)
            {
                return NotFound();
            }

            return View(nguoi);
        }

        // GET: Nguoi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nguoi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Addrest")] Nguoi nguoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguoi);
        }

        // GET: Nguoi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoi = await _context.Nguoi.FindAsync(id);
            if (nguoi == null)
            {
                return NotFound();
            }
            return View(nguoi);
        }

        // POST: Nguoi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Addrest")] Nguoi nguoi)
        {
            if (id != nguoi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiExists(nguoi.Id))
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
            return View(nguoi);
        }

        // GET: Nguoi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoi = await _context.Nguoi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoi == null)
            {
                return NotFound();
            }

            return View(nguoi);
        }

        // POST: Nguoi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nguoi = await _context.Nguoi.FindAsync(id);
            if (nguoi != null)
            {
                _context.Nguoi.Remove(nguoi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiExists(string id)
        {
            return _context.Nguoi.Any(e => e.Id == id);
        }
    }
}
