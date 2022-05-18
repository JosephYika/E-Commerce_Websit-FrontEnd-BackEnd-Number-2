using E_Commerce_Website.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();



                /*PianoCourses*/
                if (!context.PianoCourses.Any())
                {
                    context.PianoCourses.AddRange(new List<PianoCourse>()
                    {
                        new PianoCourse()
                        {
                            Name = "Advanced Music Thoery II",
                            Description = "Learn everything about advanced music theory",
                            Price = 150,
                            ImageURL = "Images/advancedmusic.jpg",
                            CourseCategory = CourseCategory.MusicTheory,
                            Level = "Advanced"

                        },
                         new PianoCourse()
                        {
                            Name = "Basisc of Music Theory I",
                            Description = "Learn everything about basics music theory",
                            Price = 45,
                            ImageURL = "Images/AdMusicTheory.jpg",
                            CourseCategory = CourseCategory.MusicTheory,
                            Level = "Beginner"

                        },
                          new PianoCourse()
                        {
                            Name = "Basics of Clarinet",
                            Description = "Learn everything about basics of Clarinet",
                            Price = 245,
                            ImageURL = "Images/Clarinet.jpg",
                            CourseCategory = CourseCategory.MusicPractice,
                            Level = "Beginner"
                        },
                           new PianoCourse()
                        {
                            Name = "Introduction to Piano Chords",
                            Description = "Learn everything about basics of piano chords",
                            Price = 45,
                            ImageURL = "Images/Piano.jpg",
                            CourseCategory = CourseCategory.MusicPractice,
                            Level = "Beginner"

                        },
                            new PianoCourse()
                        {
                            Name = "Introduction to Saxophone",
                            Description = "Learn everything about  basics of saxophone",
                            Price = 150,
                            ImageURL = "Images/Saxophone (2).jpg",
                            CourseCategory = CourseCategory.MusicPractice,
                            Level = "Beginner"

                        },
                             new PianoCourse()
                        {
                            Name = "Music Production",
                            Description = "Learn everything about the basics of music production",
                            Price = 55,
                            ImageURL = "Images/Image2.jpg",
                            CourseCategory = CourseCategory.MusicPractice,
                            Level = "Beginner"

                        },
                    });
                    context.SaveChanges();
                }

                /*Authors and Courses*/
                if (!context.AuthorsCourses.Any())
                {
                    

                }

            }

            
        }

    }
}
