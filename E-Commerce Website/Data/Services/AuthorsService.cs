using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly ApplicationDbContext _context;

        public AuthorsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Author author)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Author Update(int id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
