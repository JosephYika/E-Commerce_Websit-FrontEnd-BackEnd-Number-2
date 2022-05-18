using E_Commerce_Website.Data;
using E_Commerce_Website.Data.Services;
using E_Commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<IActionResult> Filter(string searchString)
        {
            var allPianoCourses = await _service.GetAllAsync();

            if(!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allPianoCourses.Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }
            return View("Index", allPianoCourses);
            
        }



        public async Task<IActionResult> Details (int id)
        {
            var pianoCourseDetail = await _service.GetPianoCourseByIdAsync(id);
            return View(pianoCourseDetail);
        }

        public async Task<IActionResult> Create()
        {
            var pianoCourseDropDownData = await _service.GetNewPianoCourseDropDownValues();

            ViewBag.Authors = new SelectList(pianoCourseDropDownData.Authors, "Id", "FullName");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(newPianoCourseVM course)
        {
            if (!ModelState.IsValid)
            {
                var pianoCourseDropDownData = await _service.GetNewPianoCourseDropDownValues();
                ViewBag.Authors = new SelectList(pianoCourseDropDownData.Authors, "Id", "FullName");
                return View(course);
            }

            await _service.AddNewPianoCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {

            var pianoCourseDetails = await _service.GetPianoCourseByIdAsync(id);
            if (pianoCourseDetails == null) return View("NotFound");


            var response = new newPianoCourseVM()
            {
                Id = pianoCourseDetails.Id,
                Name = pianoCourseDetails.Name,
                Description = pianoCourseDetails.Description,
                Price = pianoCourseDetails.Price,
                Level = pianoCourseDetails.Level,
                ImageURL = pianoCourseDetails.ImageURL,
                CourseCategory = pianoCourseDetails.CourseCategory,
                AuthorIds = pianoCourseDetails.Authors_Courses.Select(n => n.AuthorId).ToList(),
            };

            var pianoCourseDropDownData = await _service.GetNewPianoCourseDropDownValues();

            ViewBag.Authors = new SelectList(pianoCourseDropDownData.Authors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, newPianoCourseVM course)
        {


            if (id != course.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var pianoCourseDropDownData = await _service.GetNewPianoCourseDropDownValues();
                ViewBag.Authors = new SelectList(pianoCourseDropDownData.Authors, "Id", "FullName");
                return View(course);
            }

            await _service.UpdatePianoCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }
    }
}
