using E_Commerce_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.ViewModels
{
    public class NewPianoCourseDropDownVM
    {

        public NewPianoCourseDropDownVM()
        {
            Authors = new List<Author>();
        }
        public List<Author> Authors { get; set; }
    }
}
