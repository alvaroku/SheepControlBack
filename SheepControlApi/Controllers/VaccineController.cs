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
    public class VaccineController : ControllerBase
    {
        IVaccineBusiness _Business;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
 
        IFileManager _fileManager { get; set; }
        public VaccineController(IVaccineBusiness VaccineBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness, IFileManager fileManager)
        {
            _Business = VaccineBusiness;
            _HostEnvironment = hostEnvironment;
            _AuthenticationBusiness = authenticationBusiness;
            _fileManager = fileManager;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINE, DefaultInformationDbConstants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(await _Business.Read());
        }

        [HttpGet("GetImage/{imageName}")]
        public  async Task<IActionResult> GetImage(string imageName)
        {
            FileStream fileStream = _Business.GetImage(imageName);
            return File(fileStream, "image/jpeg");
        }

        // GET api/<VaccineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VaccineController>
        [HttpPost]
        public  async Task<IActionResult> Post([FromForm] VaccineRequest vaccineRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINE, DefaultInformationDbConstants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Create(vaccineRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<VaccineController>/5
        [HttpPut("{id}")]
        public  async Task<IActionResult> Put(int id, [FromForm] VaccineUpdateRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINE, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineController>/5
        [HttpDelete("{id}")]
        public  async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINE, DefaultInformationDbConstants.ACTION_DELETE);

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

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINE, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
