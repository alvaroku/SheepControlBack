using Business.Definitions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        IVaccineBusiness _VaccineBusiness;
        public VaccineController(IVaccineBusiness VaccineBusiness)
        {
            _VaccineBusiness = VaccineBusiness;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VaccineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VaccineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VaccineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VaccineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
