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
    public class EnquiriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnquiriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enquiries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enquiries.ToListAsync());
        }

        // GET: Enquiries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries
                .FirstOrDefaultAsync(m => m.EnquiryID == id);
            if (enquiry == null)
            {
                return NotFound();
            }

            return View(enquiry);
        }

        // GET: Enquiries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enquiries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnquiryID,UserID,EnquiryDate,About,Phone,Name")] Enquiry enquiry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enquiry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enquiry);
        }

        // GET: Enquiries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries.FindAsync(id);
            if (enquiry == null)
            {
                return NotFound();
            }
            return View(enquiry);
        }

        // POST: Enquiries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnquiryID,UserID,EnquiryDate,About,Phone,Name")] Enquiry enquiry)
        {
            if (id != enquiry.EnquiryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enquiry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnquiryExists(enquiry.EnquiryID))
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
            return View(enquiry);
        }

        // GET: Enquiries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries
                .FirstOrDefaultAsync(m => m.EnquiryID == id);
            if (enquiry == null)
            {
                return NotFound();
            }

            return View(enquiry);
        }

        // POST: Enquiries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enquiry = await _context.Enquiries.FindAsync(id);
            _context.Enquiries.Remove(enquiry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnquiryExists(int id)
        {
            return _context.Enquiries.Any(e => e.EnquiryID == id);
        }
    }
}
