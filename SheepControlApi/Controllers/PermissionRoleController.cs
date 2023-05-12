using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionRoleController : ControllerBase
    {
        IPermissionRoleBusiness _PermissionRoleBusiness;
        public PermissionRoleController(IPermissionRoleBusiness permissionRoleBusiness)
        {
            _PermissionRoleBusiness = permissionRoleBusiness;
        }
        // GET: api/<PermissionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_PermissionRoleBusiness.Read());
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermissionController>
        [HttpPost]
        public IActionResult Post(PermissionRoleRequest permissionRequest)
        {
            var response = _PermissionRoleBusiness.Create(permissionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, PermissionRoleRequest actionRequest)
        {
            var response = _PermissionRoleBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _PermissionRoleBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
