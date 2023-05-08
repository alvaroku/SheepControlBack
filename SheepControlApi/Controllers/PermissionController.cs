using Business.Definitions;
using Business.Implementations;
using DataAccess.Migrations;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        IPermissionBusiness _PermissionBusiness;
        public PermissionController(IPermissionBusiness permissionBusiness)
        {
            _PermissionBusiness = permissionBusiness;
        }
        // GET: api/<PermissionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_PermissionBusiness.Read());
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermissionController>
        [HttpPost]
        public IActionResult Post(PermissionRequest permissionRequest)
        {
            var response = _PermissionBusiness.Create(permissionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, PermissionRequest actionRequest)
        {
            var response = _PermissionBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _PermissionBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
