using Azure;
using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using DataAccess.Migrations;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheepController : ControllerBase
    {
        ISheepBusiness SheepBusiness;
        IWebHostEnvironment _HostEnvironment;

        public SheepController(ISheepBusiness sheepBusiness, IWebHostEnvironment hostEnvironment)
        {
            SheepBusiness = sheepBusiness;
            _HostEnvironment = hostEnvironment;
        }


        // GET: api/<SheepController>
        [HttpGet]
        public IActionResult Get()
        {
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
            sheepRequest.Photo = UploaderFile.UploadImage(_HostEnvironment.WebRootPath, Constants.SHEEPIMAGEPATH, sheepRequest.ImageFile);
            var response = SheepBusiness.Create(sheepRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);

        }

        // PUT api/<SheepController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] SheepRequest sheepRequest)
        {
            if(sheepRequest.ImageFile != null)
            {
                string _path = Path.Combine(_HostEnvironment.WebRootPath, Constants.SHEEPIMAGEPATH, sheepRequest.Photo);
                if (System.IO.File.Exists(_path))
                {
                    System.IO.File.Delete(_path);
                }
                var imageName = Guid.NewGuid().ToString() + Path.GetExtension(sheepRequest.ImageFile.FileName);
                var imagePath = Path.Combine(_HostEnvironment.WebRootPath, Constants.SHEEPIMAGEPATH, imageName);
                sheepRequest.Photo = imageName;
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    sheepRequest.ImageFile.CopyTo(stream);
                    
                }
            }
            var response = SheepBusiness.Update(id,sheepRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<SheepController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SheepResponse s = SheepBusiness.GetById(id).Data;
            string _path = Path.Combine(_HostEnvironment.WebRootPath, Constants.SHEEPIMAGEPATH, s.Photo);
            if (System.IO.File.Exists(_path))
            {
                System.IO.File.Delete(_path);
            }
            var response = SheepBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
