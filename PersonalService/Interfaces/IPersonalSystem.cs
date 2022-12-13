using PersonalService.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace PersonalService.Interfaces
{
    public interface IPersonalSystem
    {
        public Task<List<Personal>> GetAsync();
        public Personal Search(int id);
        public void Add(Personal personal);
        public void Update(Personal request);
        public void Delete(Personal request);
    }
}
