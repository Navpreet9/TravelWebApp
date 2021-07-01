using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelWebApp.Data;
using TravelWebApp.Models;

namespace TravelWebApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class CruisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CruisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cruises
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cruises.ToListAsync());
        }

        // GET: Cruises/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruise = await _context.Cruises
                .FirstOrDefaultAsync(m => m.CruiseID == id);
            if (cruise == null)
            {
                return NotFound();
            }

            return View(cruise);
        }

        // GET: Cruises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cruises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CruiseID,CruiseLine,DestinationName,Description,Price")] Cruise cruise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cruise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cruise);
        }

        // GET: Cruises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruise = await _context.Cruises.FindAsync(id);
            if (cruise == null)
            {
                return NotFound();
            }
            return View(cruise);
        }

        // POST: Cruises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CruiseID,CruiseLine,DestinationName,Description,Price")] Cruise cruise)
        {
            if (id != cruise.CruiseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cruise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CruiseExists(cruise.CruiseID))
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
            return View(cruise);
        }

        // GET: Cruises/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruise = await _context.Cruises
                .FirstOrDefaultAsync(m => m.CruiseID == id);
            if (cruise == null)
            {
                return NotFound();
            }

            return View(cruise);
        }

        // POST: Cruises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cruise = await _context.Cruises.FindAsync(id);
            _context.Cruises.Remove(cruise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CruiseExists(int id)
        {
            return _context.Cruises.Any(e => e.CruiseID == id);
        }
    }
}
