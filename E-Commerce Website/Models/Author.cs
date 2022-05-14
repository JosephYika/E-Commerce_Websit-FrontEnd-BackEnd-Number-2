using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class Author
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Image URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Authors Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Authors Biography")]
        public string Bio { get; set; }


        public List<Author_Course> Authors_Courses { get; set; }
    }
}
