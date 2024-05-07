using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        IControllerBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public ControllerController(IControllerBusiness controllerBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = controllerBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<ControllerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(_Business.Read());
        }

        // GET api/<ControllerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControllerController>
        [HttpPost]
        public async Task<IActionResult> Post(ControllerRequest controllerRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Create(controllerRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<ControllerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ControllerRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response2 =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_UPDATE);

            if (!response2.Success)
            {
                return StatusCode(response2.StatusCode, response2);
            }
            var response = _Business.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<ControllerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }

            var response2 = _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
