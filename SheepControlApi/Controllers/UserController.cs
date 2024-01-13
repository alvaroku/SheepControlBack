using Business.Definitions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Entities.DTOs;
using Business.Utils;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IFileManager _fileManager;
        IUserBusiness _Business { get; set; }
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        IWebHostEnvironment _HostEnvironment;
        string ResourcePath = string.Empty;
        public UserController(IFileManager fileManager,IUserBusiness userBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = userBusiness;
            _AuthenticationBusiness = authenticationBusiness;
            _HostEnvironment = hostEnvironment;
            ResourcePath =  Constants.USERIMAGEPATH;
            _fileManager = fileManager;
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
            return Ok(_Business.Read());
        }
        [HttpGet("GetImage/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            FileStream fileStream = _Business.GetImage(imageName);
            return File(fileStream, "image/jpeg");
        }
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post(UserRequest userRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_CREATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = _Business.Create(userRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, UserRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = _Business.Update(id,request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPut("UpdateProfile/{id}")]
        public IActionResult UpdateProfile(int id,[FromForm] ProfileRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATEPROFILE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }

            var response = _Business.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPut("ChangePassword/{id}")]
        public IActionResult ChangePassword(int id,ChangePasswordRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATEPROFILE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = _Business.ChangePassword(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        //[Authorize]//para que solo tenga acceso cuando se envie un token válido
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_DELETE);

            if (!response.Success) 
            {
                return StatusCode(response.StatusCode,response);
            }

            response = _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);

        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest log)
        {
            var response = _AuthenticationBusiness.Auth(log);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("GetEmailFromToken")]
        public IActionResult GetEmailFromToken(EmailRequest request)
        {
            var response = _AuthenticationBusiness.GetEmailFromToken(request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("GetProfileInfoByToken")]
        public IActionResult GetProfileInfoByToken()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var response = _AuthenticationBusiness.GetProfileInfoByToken(identity);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public IActionResult ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_TOGGLEACTIVE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 = _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
        [HttpPost("RecoveryPassword")]
        public IActionResult Login(string email)
        {
            
            var response = _Business.RecoveryPassword(email);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
