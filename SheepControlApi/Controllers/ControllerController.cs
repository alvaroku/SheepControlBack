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
        IControllerBusiness _ControllerBusiness;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public ControllerController(IControllerBusiness controllerBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _ControllerBusiness = controllerBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<ControllerController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
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
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _ControllerBusiness.Create(controllerRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<ControllerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ControllerRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response2 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_UPDATE);

            if (!response2.Success)
            {
                return StatusCode(response2.StatusCode, response2);
            }
            var response = _ControllerBusiness.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<ControllerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_CONTROLLER, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _ControllerBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
