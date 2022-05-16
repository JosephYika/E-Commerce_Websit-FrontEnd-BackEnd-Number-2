using E_Commerce_Website.Data;
using E_Commerce_Website.Data.Services;
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
        private readonly IPianoCoursesService _service;

        public PianoCoursesController(IPianoCoursesService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var allPianoCourses = await _service.GetAllAsync();
            return View(allPianoCourses);
        }


        public async Task<IActionResult> Details (int id)
        {
            var pianoCourseDetail = await _service.GetPianoCourseByIdAsync(id);
            return View(pianoCourseDetail);
        }
    }
}
