using Microsoft.AspNetCore.Mvc;
using PersonalService.Interfaces;
<<<<<<< HEAD
=======
using System.Security.Cryptography.Xml;
>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f

namespace PersonalService.Controllers
{
    [ApiController]
    [Route("[controller]")]
<<<<<<< HEAD
=======


>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
    public class PersonalControllers : ControllerBase
    {
        private readonly IPersonalService _personalService;

        public PersonalControllers(IPersonalService personalService)
        {
            _personalService = personalService;
        }
<<<<<<< HEAD
        
        private static List<Personal> mockPersonal = new()
        {
           new Personal
           {
               Id = 1,
               NationalId = "13595581052",
               Name = "Tarık Talha",
               Surname = "DİNÇ",
               Age = 20,
               Salary = 5500,
           },

           new Personal()
           {
               Id = 2,
               NationalId = "13595581054",
               Name = "Görkem",
               Surname = "Tekin",
               Age = 20,
               Salary = 7500,
           }
        };

        [HttpGet]
        [Route("PersonalList")]
        public async Task<ActionResult<Personal>> GetPersonals()
=======

        [HttpGet]
        [Route("ListPersonal")]
        public async Task<ActionResult<Personal>> Get()
>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
        {
            return Ok(_personalService.Get());
        }

        [HttpGet]
        [Route("SearchPersonal")]

<<<<<<< HEAD
        public async Task<ActionResult<Personal>> SearchPersonal(string nationalId)
        {
            var personel = _personalService.Search(nationalId);
            
            if (personel == null)
                return BadRequest("No Data");
        
          return Ok(personel);
        }
        
        [HttpPost]
        [Route("AddPersonal")]
        public async Task<ActionResult<bool>> AddPersonals(Personal personal)
        {
          var tempPersonel = personal;
          _personalService.Add(tempPersonel);

          return Ok(true);
=======
        public async Task<ActionResult<Personal>> Search(string nationalId)
        {
            var personel = _personalService.Search(nationalId);
            if (personel == null)
                return BadRequest("No Data");
            return Ok(personel);
        }

        [HttpPost]
        [Route("AddPersonal")]
        public async Task<ActionResult<bool>> Add(Personal personal)
        {
            var tempPersonel = personal;
            _personalService.Add(tempPersonel);
            return Ok(true);
>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
        }

        [HttpPut]
        [Route("UpdatePersonal")]
<<<<<<< HEAD
        public async Task<ActionResult<Personal>> UpdatePersonals(Personal request)
        { 
            _personalService.Update(request.NationalId);
          return Ok();
=======
        public async Task<ActionResult<Personal>> Update(Personal request)
        {
            _personalService.Update(request);
            return BadRequest("No personal Data");
            return Ok();
>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
        }

        [HttpDelete]
        [Route("DeletePersonal")]
<<<<<<< HEAD
        public async Task<ActionResult<Personal>> DeletePersonals(Personal request)
        {
            _personalService.Delete(request.Id);
            
          return Ok();
        }   
=======
        public async Task<ActionResult<Personal>> Delete(Personal request)
        {
            _personalService.Delete(request);
            return Ok();
        }
>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
    }
}