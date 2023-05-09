using Azure;
using Business.Definitions;
using Business.Implementations;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineSheepController : ControllerBase
    {
        IVaccineSheepBusiness _VaccineSheepBusiness;
        IWebHostEnvironment _HostEnvironment;
        public VaccineSheepController(IVaccineSheepBusiness vaccineSheepBusiness, IWebHostEnvironment hostEnvironment)
        {
            _VaccineSheepBusiness = vaccineSheepBusiness;
            _HostEnvironment = hostEnvironment;
        }
        // GET: api/<VaccineSheepController>
        [HttpGet]
        public IActionResult Get()
        {
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
            var response = _VaccineSheepBusiness.Update(id, request);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<VaccineSheepController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
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
