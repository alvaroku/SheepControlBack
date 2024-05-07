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
        public async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_READ);

            if (!response.Success)
            {
              return StatusCode(response.StatusCode, response);
            }
            return Ok(await _Business.Read());
        }
        [HttpGet("GetImage/{imageName}")]
        public async Task<IActionResult> GetImage(string imageName)
        {
            FileStream fileStream = await _Business.GetImage(imageName);
            return File(fileStream, "image/jpeg");
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post(UserRequest userRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_CREATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = await _Business.Create(userRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UserRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth =await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response = await _Business.Update(id,request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPut("UpdateProfile/{id}")]
        public async Task<IActionResult> UpdateProfile(int id,[FromForm] ProfileRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATEPROFILE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }

            var response =await _Business.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPut("ChangePassword/{id}")]
        public  async Task<IActionResult> ChangePassword(int id,ChangePasswordRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_UPDATEPROFILE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response =await _Business.ChangePassword(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        //[Authorize]//para que solo tenga acceso cuando se envie un token válido
        public async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_DELETE);

            if (!response.Success) 
            {
                return StatusCode(response.StatusCode,response);
            }

            response = await _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);

        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest log)
        {
            var response = await _AuthenticationBusiness.Auth(log);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("GetEmailFromToken")]
        public  async Task<IActionResult> GetEmailFromToken(EmailRequest request)
        {
            var response = _AuthenticationBusiness.GetEmailFromToken(request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("GetProfileInfoByToken")]
        public async Task<IActionResult> GetProfileInfoByToken()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var response =await _AuthenticationBusiness.GetProfileInfoByToken(identity);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_USER, Constants.ACTION_TOGGLEACTIVE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
        [HttpPost("RecoveryPassword")]
        public async Task<IActionResult> RecoveryPassword(string email)
        {
            var response =await _Business.RecoveryPassword(email);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
