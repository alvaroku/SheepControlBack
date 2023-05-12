using Azure;
using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using DataAccess.Migrations;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheepController : ControllerBase
    {
        ISheepBusiness SheepBusiness;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        string _fullPathImage = string.Empty;

        public SheepController(ISheepBusiness sheepBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            SheepBusiness = sheepBusiness;
            _HostEnvironment = hostEnvironment;
            _fullPathImage = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH);
            _AuthenticationBusiness = authenticationBusiness;
        }


        // GET: api/<SheepController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_SHEEP, Constants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(SheepBusiness.Read());
        }
        [HttpGet("GetImage/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var filePath = Path.Combine(_HostEnvironment.WebRootPath, Constants.SHEEPIMAGEPATH + imageName);
            var fileStream = new FileStream(filePath, FileMode.Open);
            return File(fileStream, "image/jpeg");
        }  

        // GET api/<SheepController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var response = SheepBusiness.GetById(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
   
        }

        // POST api/<SheepController>
        [HttpPost]
        public IActionResult Post([FromForm] SheepRequest sheepRequest)

        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_SHEEP, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            sheepRequest.Photo = FileManager.UploadImage(_fullPathImage, sheepRequest.ImageFile);
            var response = SheepBusiness.Create(sheepRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);

        }

        // PUT api/<SheepController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] SheepRequest sheepRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_SHEEP, Constants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = SheepBusiness.Update(id,sheepRequest,_fullPathImage);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<SheepController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_SHEEP, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = SheepBusiness.Delete(id,_fullPathImage);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
