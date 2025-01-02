using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using hoten_1234_2425_baithitest;

namespace hoten_1234_2425_BAITHITEST_.Controllers
{
    public class sinhvienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public sinhvienController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: sinhvien
        public async Task<IActionResult> Index()
        {
            return View(await _context.sinhvien.ToListAsync());
        }

        // GET: sinhvien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.sinhvien
                .FirstOrDefaultAsync(m => m.mssv == id);
            if (sinhvien == null)
            {
                return NotFound();
            }

            return View(sinhvien);
        }

        // GET: sinhvien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sinhvien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("hoten,mssv")] sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinhvien);
        }

        // GET: sinhvien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.sinhvien.FindAsync(id);
            if (sinhvien == null)
            {
                return NotFound();
            }
            return View(sinhvien);
        }

        // POST: sinhvien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("hoten,mssv")] sinhvien sinhvien)
        {
            if (id != sinhvien.mssv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhvien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sinhvienExists(sinhvien.mssv))
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
            return View(sinhvien);
        }

        // GET: sinhvien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _context.sinhvien
                .FirstOrDefaultAsync(m => m.mssv == id);
            if (sinhvien == null)
            {
                return NotFound();
            }

            return View(sinhvien);
        }

        // POST: sinhvien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sinhvien = await _context.sinhvien.FindAsync(id);
            if (sinhvien != null)
            {
                _context.sinhvien.Remove(sinhvien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sinhvienExists(string id)
        {
            return _context.sinhvien.Any(e => e.mssv == id);
        }
    }
}
