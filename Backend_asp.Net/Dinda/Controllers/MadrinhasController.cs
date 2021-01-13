using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dinda.Models;

namespace Dinda.Controllers
{
    public class MadrinhasController : Controller
    {
        private readonly Context _context;

        public MadrinhasController(Context context)
        {
            _context = context;
        }

        // GET: Madrinhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Madrinhas.ToListAsync());
        }

        // GET: Madrinhas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madrinha = await _context.Madrinhas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (madrinha == null)
            {
                return NotFound();
            }

            return View(madrinha);
        }

        // GET: Madrinhas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Madrinhas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CanTeach,Id,Name,Cpf,Location,DateBirth,PhoneNumber,Email,Hobbies,DaysAvailable")] Madrinha madrinha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(madrinha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(madrinha);
        }

        // GET: Madrinhas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madrinha = await _context.Madrinhas.FindAsync(id);
            if (madrinha == null)
            {
                return NotFound();
            }
            return View(madrinha);
        }

        // POST: Madrinhas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CanTeach,Id,Name,Cpf,Location,DateBirth,PhoneNumber,Email,Hobbies,DaysAvailable")] Madrinha madrinha)
        {
            if (id != madrinha.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(madrinha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MadrinhaExists(madrinha.Id))
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
            return View(madrinha);
        }

        // GET: Madrinhas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var madrinha = await _context.Madrinhas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (madrinha == null)
            {
                return NotFound();
            }

            return View(madrinha);
        }

        // POST: Madrinhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var madrinha = await _context.Madrinhas.FindAsync(id);
            _context.Madrinhas.Remove(madrinha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MadrinhaExists(int id)
        {
            return _context.Madrinhas.Any(e => e.Id == id);
        }
    }
}
