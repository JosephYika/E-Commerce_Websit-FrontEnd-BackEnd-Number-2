using E_Commerce_Website.Data;
using E_Commerce_Website.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class newPianoCourseVM
    {  
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Display(Name = "Course Price")]
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }


        [Display(Name = "Image URL")]
        [Required(ErrorMessage = "Image URL required")]
        public string ImageURL { get; set; }

        [Display(Name = "Course Level")]
        [Required(ErrorMessage = "Level is required")]
        public string Level { get; set; }

        [Display(Name = "Course Category")]
        [Required(ErrorMessage = "Category required")]
        public CourseCategory CourseCategory { get; set; }


        /*One Course can have one or multiple authors. This means that I have to have a joint table
         between a Course and Authors*/
        [Display(Name = "Authors associated with the course")]
        [Required(ErrorMessage = "At least one author is required")]
        public List<int> AuthorIds { get; set; }

  
        public List<Author> Authors { get; set; }


    }
}
