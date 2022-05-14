using E_Commerce_Website.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Controllers
{
    public class PianoCoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PianoCoursesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var allPianoCourses = await _context.PianoCourses.ToListAsync();
            return View(allPianoCourses);
        }
    }
}
