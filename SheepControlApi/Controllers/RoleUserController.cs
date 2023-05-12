using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleUserController : ControllerBase
    {
        IRoleUserBusiness _RoleUserBusiness;
        public RoleUserController(IRoleUserBusiness RoleUserBusiness)
        {
            _RoleUserBusiness = RoleUserBusiness;
        }
        // GET: api/<PermissionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_RoleUserBusiness.Read());
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermissionController>
        [HttpPost]
        public IActionResult Post(RoleUserRequest permissionRequest)
        {
            var response = _RoleUserBusiness.Create(permissionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, RoleUserRequest actionRequest)
        {
            var response = _RoleUserBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _RoleUserBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
