using Business.Definitions;
using Business.Implementations;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
 
using Microsoft.AspNetCore.Authorization;
using Entities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBusiness _UserBusiness { get; set; }
        public UserController(IUserBusiness userBusiness) {
            _UserBusiness = userBusiness;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            //var u = new User { Name ="Alvaro",Active = true,LastName="Kú",CreationDate=DateTime.Now,Email="alvaro@gmail.com",Guid = Guid.NewGuid(),ModificationDate= DateTime.Now ,Password="222",PhoneNumber="9919"};
            //_UserBusiness.Create(u);
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

            var responseAuth = _UserBusiness.ValidarToken(identity);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            UserResponse userAuth = responseAuth.Data;
            userAuth.Rol = "Admin";
            if (userAuth.Rol!="Admin") {
                responseAuth.Success = false;
                responseAuth.Data = null;
                responseAuth.Message = "No tienes los permisos suficientes";
                responseAuth.StatusCode = (int)EnumStatusCode.Forbidden;
                return StatusCode(responseAuth.StatusCode,responseAuth);
            }
            return Ok(responseAuth.Message=$"Borrado -> id {id}");

        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest log)
        {
            var response = _UserBusiness.Login(log);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
