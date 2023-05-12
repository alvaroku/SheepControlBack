using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        IRoleBusiness _RoleBusiness;
        public RoleController(IRoleBusiness RoleBusiness)
        {
            _RoleBusiness = RoleBusiness;
        }
        // GET: api/<Controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_RoleBusiness.Read());
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Controller>
        [HttpPost]
        public IActionResult Post(RoleRequest Request)
        {
            var response = _RoleBusiness.Create(Request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<Controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, RoleRequest actionRequest)
        {
            var response = _RoleBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _RoleBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
