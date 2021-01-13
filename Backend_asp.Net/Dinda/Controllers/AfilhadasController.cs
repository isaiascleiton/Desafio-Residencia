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
    public class AfilhadasController : Controller
    {
        private readonly Context _context;

        public AfilhadasController(Context context)
        {
            _context = context;
        }

        // GET: Afilhadas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Afilhadas.ToListAsync());
        }

        // GET: Afilhadas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afilhada = await _context.Afilhadas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (afilhada == null)
            {
                return NotFound();
            }

            return View(afilhada);
        }

        // GET: Afilhadas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Afilhadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WantToLearn,Id,Name,Cpf,Location,DateBirth,PhoneNumber,Email,Hobbies,DaysAvailable")] Afilhada afilhada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afilhada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(afilhada);
        }

        // GET: Afilhadas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afilhada = await _context.Afilhadas.FindAsync(id);
            if (afilhada == null)
            {
                return NotFound();
            }
            return View(afilhada);
        }

        // POST: Afilhadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WantToLearn,Id,Name,Cpf,Location,DateBirth,PhoneNumber,Email,Hobbies,DaysAvailable")] Afilhada afilhada)
        {
            if (id != afilhada.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afilhada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfilhadaExists(afilhada.Id))
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
            return View(afilhada);
        }

        // GET: Afilhadas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afilhada = await _context.Afilhadas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (afilhada == null)
            {
                return NotFound();
            }

            return View(afilhada);
        }

        // POST: Afilhadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var afilhada = await _context.Afilhadas.FindAsync(id);
            _context.Afilhadas.Remove(afilhada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfilhadaExists(int id)
        {
            return _context.Afilhadas.Any(e => e.Id == id);
        }
    }
}
