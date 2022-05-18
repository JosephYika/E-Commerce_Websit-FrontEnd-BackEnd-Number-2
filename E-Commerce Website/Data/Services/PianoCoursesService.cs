using E_Commerce_Website.Data.Base;
using E_Commerce_Website.Data.ViewModels;
using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public class PianoCoursesService : EntityBaseRepository<PianoCourse>, IPianoCoursesService
    {
        private readonly ApplicationDbContext _context;
        public PianoCoursesService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewPianoCourseAsync(newPianoCourseVM data)
        {
            var newPianoCourse = new PianoCourse()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                CourseCategory = data.CourseCategory,
                Level = data.Level,
                ImageURL = data.ImageURL,
                

            };
            await _context.PianoCourses.AddAsync(newPianoCourse);
            await _context.SaveChangesAsync();

            foreach (var authorId in data.AuthorIds)
            {
                var newAuthorPianoCourse = new Author_Course()
                {
                    PianoCourseId = newPianoCourse.Id,
                    AuthorId = authorId
                };
                await _context.AuthorsCourses.AddAsync(newAuthorPianoCourse);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<NewPianoCourseDropDownVM> GetNewPianoCourseDropDownValues()
        {

            var response = new NewPianoCourseDropDownVM()
            {
                Authors = await _context.Authors.OrderBy(n => n.FullName).ToListAsync(),
            };
            
            return response;
        }

    public async Task<PianoCourse> GetPianoCourseByIdAsync(int id)
    {
        var pianoCourseDetails = await _context.PianoCourses
            .Include(am => am.Authors_Courses).ThenInclude(a => a.Author)
            .FirstOrDefaultAsync(n => n.Id == id);

        return pianoCourseDetails;
    }

        public async Task UpdatePianoCourseAsync(newPianoCourseVM data)
        {

            var dbCourse = await _context.PianoCourses.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbCourse != null)
            {

                dbCourse.Name = data.Name;
                dbCourse.Description = data.Description;
                dbCourse.Price = data.Price;
                dbCourse.CourseCategory = data.CourseCategory;
                dbCourse.Level = data.Level;
                dbCourse.ImageURL = data.ImageURL;


                
               
                await _context.SaveChangesAsync();

            }

            var existingAuthorDb = _context.AuthorsCourses.Where(n => n.PianoCourseId == data.Id).ToList();
            _context.AuthorsCourses.RemoveRange(existingAuthorDb);
            await _context.SaveChangesAsync();
           

            foreach (var authorId in data.AuthorIds)
            {
                var newAuthorPianoCourse = new Author_Course()
                {
                    PianoCourseId = data.Id,
                    AuthorId = authorId
                };
                await _context.AuthorsCourses.AddAsync(newAuthorPianoCourse);
            }
            await _context.SaveChangesAsync();

        }
    }
}
