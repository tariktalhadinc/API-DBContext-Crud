using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace PersonalService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalsController : ControllerBase
    {
        private readonly PersonalDataContext _context;

        public PersonalsController(PersonalDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Personal>>> GetAsync()
        {
            return Ok(await _context.Personals.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]

        public async Task<ActionResult<Personal>> Search(string id)
        {
            var Personal = await _context.Personals.FindAsync(id);
            if (Personal == null)
                return BadRequest("No Data");
            return Ok(Personal);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<List<Personal>>> Add(Personal personal)
        {
          _context.Personals.Add(personal);
            await _context.SaveChangesAsync();

            return Ok(await _context.Personals.ToListAsync());
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<List<Personal>>> Update(Personal request)
        {
          var Personal = await _context.Personals.FindAsync(request.Id);
          if (Personal == null)
              return BadRequest("No personal Data");
          Personal.Name = request.Surname;
          Personal.Surname = request.Name;
          Personal.Salary = request.Salary;
            return Ok(await _context.Personals.ToListAsync());
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<List<Personal>>> Delete(int id)
        {
            var personal = await _context.Personals.FindAsync(id);
            if (personal == null)
                return BadRequest("No Data");

            _context.Personals.Remove(personal);
          return Ok(personal);
        }   
    }
}
