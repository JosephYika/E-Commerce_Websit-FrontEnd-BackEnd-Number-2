using E_Commerce_Website.Data.Base;
using E_Commerce_Website.Data.ViewModels;
using E_Commerce_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public interface IPianoCoursesService: IEntityBaseRepository<PianoCourse>
    {
        Task<PianoCourse> GetPianoCourseByIdAsync(int id);

        Task<NewPianoCourseDropDownVM> GetNewPianoCourseDropDownValues();

        Task AddNewPianoCourseAsync(newPianoCourseVM data);
        Task UpdatePianoCourseAsync(newPianoCourseVM data);
    }
}
