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
    public class VaccineSheepController : ControllerBase
    {
        IVaccineSheepBusiness _VaccineSheepBusiness;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public VaccineSheepController(IVaccineSheepBusiness vaccineSheepBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            _VaccineSheepBusiness = vaccineSheepBusiness;
            _HostEnvironment = hostEnvironment;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<VaccineSheepController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESHEEP, Constants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(_VaccineSheepBusiness.ReadIncludes());
        }
        [HttpPost("GetVaccineSheepWithFilters")]
        public IActionResult GetVaccineSheepWithFilters(FilterVaccineSheepRequest request)
        {
            return Ok(_VaccineSheepBusiness.ReadIncludesWithFilters(request));
        }
        // GET api/<VaccineSheepController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VaccineSheepController>
        [HttpPost]
        public IActionResult Post(VaccineSheepRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESHEEP, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _VaccineSheepBusiness.Create(request);

            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("ApplyVaccineToAllSheeps")]
        public IActionResult ApplyVaccineToAllSheeps(VaccineSheepRequest request)
        {
            var response = _VaccineSheepBusiness.ApplyVaccineToAllSheeps(request);

            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<VaccineSheepController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, VaccineSheepRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESHEEP, Constants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _VaccineSheepBusiness.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineSheepController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESHEEP, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _VaccineSheepBusiness.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        // DELETE api/<VaccineSheepController>/5
        [HttpDelete("DeleteAll")]
        public IActionResult DeleteAll()
        {
            var response = _VaccineSheepBusiness.DeleteAll();
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("Report")]
        public IActionResult GetReport()
        {
            var response = _VaccineSheepBusiness.GenerateReport();
            return response.Success ? File(response.Data.Excel, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "datos.xlsx") : StatusCode(response.StatusCode, response);
         
        }
    }
}
