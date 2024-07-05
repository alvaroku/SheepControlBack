using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Security.Claims;

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleSheepController : ControllerBase
    {
        ISaleSheepBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public SaleSheepController(ISaleSheepBusiness actionBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = actionBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<SaleSheepController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SALESHEEP, DefaultInformationDbConstants.ACTION_READ);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(await _Business.Read());
        }
        [HttpPost("GetWithFilters")]
        public async Task<IActionResult> GetWithFilters(FilterSaleSheepRequest request)
        {
            return Ok(await _Business.ReadWithFilters(request));
        }
        // GET api/<SaleSheepController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SaleSheepController>
        [HttpPost]
        public async Task<IActionResult> Post(SaleMultipleSheepRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var responseAuth = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SALESHEEP, DefaultInformationDbConstants.ACTION_CREATE);

            if (!responseAuth.Success)
            {
                return StatusCode(responseAuth.StatusCode, responseAuth);
            }
            var response =await _Business.CreateMultiple(actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);

        }

        // PUT api/<SaleSheepController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, SaleSheepRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SALESHEEP, DefaultInformationDbConstants.ACTION_UPDATE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.Update(id, actionRequest);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }

        // DELETE api/<SaleSheepController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SALESHEEP, DefaultInformationDbConstants.ACTION_DELETE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.Delete(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
        // GET api/<SaleSheepController>/5
        [HttpGet("ToggleActive/{id}")]
        public async Task<IActionResult> ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response = await _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, DefaultInformationDbConstants.CONTROLLER_SALESHEEP, DefaultInformationDbConstants.ACTION_TOGGLEACTIVE);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response);
            }
            var response2 =await _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
