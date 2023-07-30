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
    public class ActionController : ControllerBase
    {
        IActionBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public ActionController(IActionBusiness actionBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = actionBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<ActionController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ACTION, Constants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(_Business.Read());
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
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ACTION, Constants.ACTION_CREATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = _Business.Create(actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
            
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ActionRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ACTION, Constants.ACTION_UPDATE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 = _Business.Update(id ,actionRequest);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ACTION, Constants.ACTION_DELETE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 = _Business.Delete(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
        // GET api/<ActionController>/5
        [HttpGet("ToggleActive/{id}")]
        public IActionResult ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_ACTION, Constants.ACTION_TOGGLEACTIVE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 = _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
