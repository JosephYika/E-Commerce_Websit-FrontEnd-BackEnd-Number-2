﻿using E_Commerce_Website.Data.Base;
using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public class AuthorsService :EntityBaseRepository<Author>, IAuthorsService
    {
      

        public AuthorsService(ApplicationDbContext context) : base(context) { }
        
     
    }
}
