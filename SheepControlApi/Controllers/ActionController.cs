using Business.Definitions;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Security.Claims;
using Shared;

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
        public async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ACTION, DefaultInformationDbConstants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(await _Business.Read());
        }


        // POST api/<ActionController>
        [HttpPost]
        public async Task<IActionResult> Post(ActionRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ACTION, DefaultInformationDbConstants.ACTION_CREATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response =await _Business.Create(actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
            
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ActionRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ACTION, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.Update(id ,actionRequest);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ACTION, DefaultInformationDbConstants.ACTION_DELETE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 = await _Business.Delete(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
        // GET api/<ActionController>/5
        [HttpGet("ToggleActive/{id}")]
        public async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_ACTION, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
