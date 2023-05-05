using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp.Formats.Jpeg;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        IVaccineBusiness _VaccineBusiness;
        IWebHostEnvironment _HostEnvironment;
        public VaccineController(IVaccineBusiness VaccineBusiness, IWebHostEnvironment hostEnvironment)
        {
            _VaccineBusiness = VaccineBusiness;
            _HostEnvironment = hostEnvironment;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public IActionResult Get()
        {
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
            vaccineRequest.Photo = UploaderFile.UploadImage(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH, vaccineRequest.ImageFile); ;
            var response = _VaccineBusiness.Create(vaccineRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<VaccineController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] VaccineRequest request)
        {
            if (request.ImageFile != null)
            {
                string _path = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH,request.Photo);
                if (System.IO.File.Exists(_path))
                {
                    System.IO.File.Delete(_path);
                }
                var imageName = Guid.NewGuid().ToString() + Path.GetExtension(request.ImageFile.FileName);
                var imagePath = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH, imageName);
                request.Photo = imageName;
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    request.ImageFile.CopyTo(stream);

                }
            }
            var response = _VaccineBusiness.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            VaccineResponse s = _VaccineBusiness.GetById(id).Data;
            string _path = Path.Combine(_HostEnvironment.WebRootPath, Constants.VACCINEIMAGEPATH, s.Photo);
            if (System.IO.File.Exists(_path))
            {
                System.IO.File.Delete(_path);
            }
            var response = _VaccineBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
    }
}
