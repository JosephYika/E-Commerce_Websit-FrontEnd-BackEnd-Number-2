﻿using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data
{
    /*Adding database context*/
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Course>().HasKey(ac => new
            {
                ac.AuthorId,
                ac.PianoCourseId
            });

            modelBuilder.Entity<Author_Course>().HasOne(m => m.PianoCourse).WithMany(ac => ac.Authors_Courses).HasForeignKey(m => m.PianoCourseId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author_Course>().HasOne(m => m.Author).WithMany(ac => ac.Authors_Courses).HasForeignKey(m => m.AuthorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get;set; }

        public DbSet<PianoCourse> PianoCourses { get; set; }

        public DbSet<Author_Course> AuthorsCourses { get; set; }


    }
}