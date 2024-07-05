using Business.Definitions;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Security.Claims;

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
        public  async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ROLE, DefaultInformationDbConstants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(await _Business.Read());
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Controller>
        [HttpPost]
        public  async Task<IActionResult> Post(RoleRequest Request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ROLE, DefaultInformationDbConstants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Create(Request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<Controller>/5
        [HttpPut("{id}")]
        public  async Task<IActionResult> Put(int id, RoleRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ROLE, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public  async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ROLE, DefaultInformationDbConstants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public  async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ROLE, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
