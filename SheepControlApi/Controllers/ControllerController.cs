using Business.Definitions;
using Business.Implementations;
using Entities.DTOs;
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
        public IActionResult Get()
        {
            return Ok(_ControllerBusiness.Read());
        }

        // GET api/<ControllerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControllerController>
        [HttpPost]
        public IActionResult Post(ControllerRequest controllerRequest)
        {
            var response = _ControllerBusiness.Create(controllerRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<ControllerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ControllerRequest actionRequest)
        {
            var response = _ControllerBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<ControllerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _ControllerBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
