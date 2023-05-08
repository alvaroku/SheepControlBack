using Business.Definitions;
using Business.Implementations;
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
        public IActionResult Post(ActionRequest actionRequest)
        {
            var response = _ActionBusiness.Create(actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
            
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ActionRequest actionRequest)
        {
            var response = _ActionBusiness.Update(id ,actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _ActionBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
