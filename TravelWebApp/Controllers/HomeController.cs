using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelWebApp.Data;
using TravelWebApp.Models;

namespace TravelWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllDestinations()
        {
            var applicationDbContext = _context.Destinations;                
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> AllFlights()
        {
            var applicationDbContext = _context.Flights
                .Include(m => m.Source)
                .Include(m => m.Destination);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> AllCruises()
        {
            var applicationDbContext = _context.Cruises;
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize]
        public IActionResult CruiseEnquiry(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cruise = _context.Cruises
                .FirstOrDefault(m => m.CruiseID == id);
            if (cruise == null)
            {
                return NotFound();
            }

            ViewData["About"] = cruise.DestinationName + " in " + cruise.CruiseLine;
            return View();
        }

        [Authorize]
        public IActionResult FlightEnquiry(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var flight = _context.Flights
                .Include(m=>m.Source)
                .Include(m=>m.Destination)
                .FirstOrDefault(m => m.FlightID == id);
            if (flight == null)
            {
                return NotFound();
            }
            string about = "";
            about = flight.Source.DestinationName + " to " + flight.Destination.DestinationName + " in " + flight.Type;
            ViewData["About"] = about;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FlightEnquiry([Bind("EnquiryID,About,Phone,Name")] Enquiry enquiry)
        {
            ModelState.Remove("EnquiryDate");
            ModelState.Remove("UserID");
            if (ModelState.IsValid)
            {
                enquiry.UserID = _userManager.GetUserName(this.User);
                enquiry.EnquiryDate = DateTime.Now;
                _context.Add(enquiry);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(UserEnquiries));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CruiseEnquiry([Bind("EnquiryID,About,Phone,Name")] Enquiry enquiry)
        {
            ModelState.Remove("EnquiryDate");
            ModelState.Remove("UserID");
            if (ModelState.IsValid)
            {
                enquiry.UserID = _userManager.GetUserName(this.User);
                enquiry.EnquiryDate = DateTime.Now;
                _context.Add(enquiry);
                await _context.SaveChangesAsync();                
            }
            return RedirectToAction(nameof(UserEnquiries));
        }


        [Authorize]
        public async Task<IActionResult> UserEnquiries()
        {
            string userid = _userManager.GetUserName(this.User);
            var reviews = _context.Enquiries
                .Where(m => m.UserID == userid);
            return View(await reviews.OrderByDescending(m => m.EnquiryID).ToListAsync());
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
}
