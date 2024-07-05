using Business.Definitions;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheepController : ControllerBase
    {
        ISheepBusiness _Business;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        
        public SheepController(ISheepBusiness sheepBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = sheepBusiness;
            _HostEnvironment = hostEnvironment;
            _AuthenticationBusiness = authenticationBusiness;
        }


        // GET: api/<SheepController>
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(await _Business.Read());
        }
        [HttpGet("GetSheepsWithFinalWeight")]
        public  async Task<IActionResult> GetSheepsWithFinalWeight()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_GETSHEEPWITHFINALWEIGHT);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(_Business.GetSheepsWithFinalWeight());
        }

        [HttpGet("GetImage/{imageName}")]
        public  async Task<IActionResult> GetImage(string imageName)
        {
            FileStream fileStream = _Business.GetImage(imageName);
            return File(fileStream, "image/jpeg");
        }  

        // GET api/<SheepController>/5
        [HttpGet("{id}")]
        public  async Task<IActionResult> Get(int id)
        {
            var response =await _Business.GetById(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // POST api/<SheepController>
        [HttpPost]
        public  async Task<IActionResult> Post([FromForm] SheepRequest sheepRequest)

        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            
            var response = await _Business.Create(sheepRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<SheepController>/5
        [HttpPut("{id}")]
        public  async Task<IActionResult> Put(int id, [FromForm] SheepRequest sheepRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Update(id,sheepRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<SheepController>/5
        [HttpDelete("{id}")]
        public  async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_DELETE);

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

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SHEEP, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
