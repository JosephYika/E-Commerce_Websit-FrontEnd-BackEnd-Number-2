using E_Commerce_Website.Data.Base;
using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public class PianoCoursesService:EntityBaseRepository<PianoCourse>, IPianoCoursesService
    {
        private readonly ApplicationDbContext _context;
        public PianoCoursesService(ApplicationDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<PianoCourse> GetPianoCourseByIdAsync(int id)
        {
            var pianoCourseDetails = await _context.PianoCourses
                .Include(am => am.Authors_Courses).ThenInclude(a => a.Author)
                .FirstOrDefaultAsync(n => n.Id == id);

            return pianoCourseDetails;
        }
    }
}
