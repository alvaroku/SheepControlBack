using Business.Definitions;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        IRoleBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public RoleController(IRoleBusiness RoleBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = RoleBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<Controller>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ROLE, Constants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(_Business.Read());
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
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ROLE, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Create(Request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<Controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, RoleRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ROLE, Constants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ROLE, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public IActionResult ToggleActive(int id)
        {
            var response2 = _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
