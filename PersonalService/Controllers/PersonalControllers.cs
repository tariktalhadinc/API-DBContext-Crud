using Microsoft.AspNetCore.Mvc;
using PersonalService.Interfaces;
using PersonalService.Model;
using System.Security.Cryptography.Xml;

namespace PersonalService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalsController : ControllerBase
    {
        private readonly IPersonalSystem _personalService;

        public PersonalsController(IPersonalSystem personalService, DataContext context)
        {
            _personalService = personalService;
            _context = context;
        }

        public DataContext _context;

        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Personal>>> GetAsync()
        {
            var personalList =await _personalService.GetAsync();
            return Ok(personalList);
        }

        [HttpGet]
        [Route("{id}")]

        public ActionResult<Personal> Search(int id)
        {
            var personalSearch = _personalService.Search(id);
            if (personalSearch == null)
                return NotFound("No Data");
            return Ok(personalSearch);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult Add(Personal personal)
        {
            _personalService.Add(personal);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Personal request)
        {
            _personalService.Update(request);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public ActionResult Delete(Personal request)
        {
            _personalService.Delete(request);
            return Ok();
        }
    }
}