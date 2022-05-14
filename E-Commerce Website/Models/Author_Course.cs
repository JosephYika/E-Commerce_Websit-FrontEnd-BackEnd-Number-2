using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class Author_Course
    {

        public int PianoCourseId { get; set; }
        public PianoCourse PianoCourse { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
