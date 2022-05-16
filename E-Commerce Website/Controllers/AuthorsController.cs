using E_Commerce_Website.Data;
using E_Commerce_Website.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Controllers
{

    public class AuthorsController : Controller
    {
        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {

            var data = await _service.GetAll();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
