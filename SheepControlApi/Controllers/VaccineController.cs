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
    public class VaccineController : ControllerBase
    {
        IVaccineBusiness _VaccineBusiness;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        string _fullPathImage = string.Empty;
        public VaccineController(IVaccineBusiness VaccineBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            _VaccineBusiness = VaccineBusiness;
            _HostEnvironment = hostEnvironment;
            _fullPathImage = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH);
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINE, Constants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(_VaccineBusiness.Read());
        }
        [HttpGet("GetImage/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var filePath = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH + imageName);
            var fileStream = new FileStream(filePath, FileMode.Open);
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
        public IActionResult Post([FromForm] VaccineRequest vaccineRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINE, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            vaccineRequest.Photo = FileManager.UploadImage(_fullPathImage, vaccineRequest.ImageFile); ;
            var response = _VaccineBusiness.Create(vaccineRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<VaccineController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] VaccineRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINE, Constants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _VaccineBusiness.Update(id, request,_fullPathImage);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINE, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _VaccineBusiness.Delete(id,_fullPathImage);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
