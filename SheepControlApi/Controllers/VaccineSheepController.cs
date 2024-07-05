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
    public class VaccineSheepController : ControllerBase
    {
        IVaccineSheepBusiness _Business;
        IWebHostEnvironment _HostEnvironment;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public VaccineSheepController(IVaccineSheepBusiness vaccineSheepBusiness, IWebHostEnvironment hostEnvironment, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = vaccineSheepBusiness;
            _HostEnvironment = hostEnvironment;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<VaccineSheepController>
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(await _Business.ReadIncludes());
        }
        [HttpPost("GetVaccineSheepWithFilters")]
        public  async Task<IActionResult> GetVaccineSheepWithFilters(FilterVaccineSheepRequest request)
        {
            return Ok(_Business.ReadIncludesWithFilters(request));
        }
        // GET api/<VaccineSheepController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VaccineSheepController>
        [HttpPost]
        public  async Task<IActionResult> Post(VaccineSheepRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Create(request);

            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpPost("ApplyVaccineToAllSheeps")]
        public  async Task<IActionResult> ApplyVaccineToAllSheeps(VaccineSheepVaccineToAllRequest request)
        {
            var response =await _Business.ApplyVaccineToAllSheeps(request);

            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<VaccineSheepController>/5
        [HttpPut("{id}")]
        public  async Task<IActionResult> Put(int id, VaccineSheepRequest request)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineSheepController>/5
        [HttpDelete("{id}")]
        public  async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        // DELETE api/<VaccineSheepController>/5
        [HttpDelete("DeleteAll")]
        public  async Task<IActionResult> DeleteAll()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_DELETEALL);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response =await _Business.DeleteAll();
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("Report")]
        public  async Task<IActionResult> GetReport()
        {
            var response =await _Business.GenerateReport();
            return response.Success ? File(response.Data.Excel, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "datos.xlsx") : StatusCode(response.StatusCode, response);
         
        }
        [HttpGet("ToggleActive/{id}")]
        public  async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_VACCINESHEEP, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
