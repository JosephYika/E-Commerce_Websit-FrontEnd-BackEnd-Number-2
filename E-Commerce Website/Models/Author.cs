using E_Commerce_Website.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class Author:IEntityBase
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Image URL")]
        [Required(ErrorMessage = "Required Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Authors Full Name")]
        [Required(ErrorMessage = "Required Author's Name")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The Name must contain at least 2 characters")]
        public string FullName { get; set; }

        [Display(Name = "Authors Biography")]
        [Required(ErrorMessage = "Required Biography")]
        public string Bio { get; set; }


        public List<Author_Course> Authors_Courses { get; set; }

        public List<PianoCourse> PianoCourses { get; set; }
    }
}
