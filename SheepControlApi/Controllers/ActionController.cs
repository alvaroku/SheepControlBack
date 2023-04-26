using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        IActionBusiness _ActionBusiness;
        public ActionController(IActionBusiness actionBusiness)
        {
            _ActionBusiness = actionBusiness;
        }
        // GET: api/<ActionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ActionBusiness.Read());
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ActionController>
        [HttpPost]
        public void Post([FromBody] ActionRequest actionRequest)
        {
            _ActionBusiness.Create(actionRequest);
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
