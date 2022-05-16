using E_Commerce_Website.Data;
using E_Commerce_Website.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class PianoCourse:IEntityBase
    {  
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string ImageURL { get; set; }

        public string Level { get; set; }

        public CourseCategory CourseCategory { get; set; }


        /*One Movie can have one or multiple authors. This means that I have to have a joint table
         between a Movie and Authors*/
        public List<Author_Course> Authors_Courses { get; set; }

        
    }
}
