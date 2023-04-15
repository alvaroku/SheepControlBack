using Business.Definitions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        IControllerBusiness _ControllerBusiness;
        public ControllerController(IControllerBusiness controllerBusiness)
        {
            _ControllerBusiness = controllerBusiness;
        }
        // GET: api/<ControllerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ControllerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControllerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ControllerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControllerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
