﻿using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineStockController : ControllerBase
    {
        IVaccineStockBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public VaccineStockController(IVaccineStockBusiness permissionBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = permissionBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<PermissionController>
        [HttpGet]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESTOCK, Constants.ACTION_READ);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            return Ok(_Business.Read());
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermissionController>
        [HttpPost]
        public IActionResult Post(VaccineStockRequest permissionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESTOCK, Constants.ACTION_CREATE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Create(permissionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, VaccineStockRequest actionRequest)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESTOCK, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Update(id, actionRequest);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESTOCK, Constants.ACTION_DELETE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response = _Business.Delete(id);
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }
        [HttpGet("ToggleActive/{id}")]
        public IActionResult ToggleActive(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var response1 = _AuthenticationBusiness.CheckPermissionControllerActionForUser(identity, Constants.CONTROLLER_VACCINESTOCK, Constants.ACTION_TOGGLEACTIVE);

            if (!response1.Success)
            {
                return StatusCode(response1.StatusCode, response1);
            }
            var response2 = _Business.ToggleActive(id);
            return response2.Success ? Ok(response2) : StatusCode(response2.StatusCode, response2);
        }
    }
}
