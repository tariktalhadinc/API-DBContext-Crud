using PersonalService.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PersonalService.Interfaces;
using System;

namespace PersonalService.Services
{
    public class PersonalSystem : IPersonalSystem
    {
        private readonly DataContext _context;

        public PersonalSystem(DataContext context)
        {
            _context = context;
        }

        public Task<List<Personal>> GetAsync()
        {
            return _context.Personals.ToListAsync();
        }

        public Personal Search(int id)
        {
            var personalList = _context.Personals;
            var personalSearch = personalList.FirstOrDefault(q => q.Id == id);

            return personalSearch;
        }

        public void Add(Personal personal)
        {
            _context.Personals.Add(personal);
            _context.SaveChangesAsync();
        }

        public void Update(Personal request)
        {
            var personalUpdate = _context.Personals.Find(request.Id);

                if (personalUpdate != null)

            personalUpdate.Salary = request.Salary;

            _context.SaveChangesAsync();
        }
        public void Delete(Personal request)
        {
            var personal = _context.Personals.Remove(request);
            _context.SaveChangesAsync();
        }
    }
}
