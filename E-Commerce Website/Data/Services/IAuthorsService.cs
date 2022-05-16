using E_Commerce_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAll();
        Author GetById(int id);

        void Add(Author author);
        Author Update(int id, Author newAuthor);

        void Delete(int id);
    }
}
