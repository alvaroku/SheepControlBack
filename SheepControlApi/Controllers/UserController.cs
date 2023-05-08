using Business.Definitions;
using Business.Implementations;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
 
using Microsoft.AspNetCore.Authorization;
using Entities.DTOs;
using Business.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBusiness _UserBusiness { get; set; }
        //IPermissionBusiness _PermissionBusiness { get; set; }
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public UserController(IUserBusiness userBusiness, IAuthenticationBusiness authenticationBusiness, IPermissionBusiness permissionBusiness)
        {
            _UserBusiness = userBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(_UserBusiness.Read());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        [Authorize]//para que solo tenga acceso cuando se envie un token válido
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_DELETE);

            if (!response.Success) 
            {
                return StatusCode(response.StatusCode,response);
            }

            return Ok(response.Message=$"Borrado -> id {id}");

        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest log)
        {
            var response = _UserBusiness.Login(log);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
