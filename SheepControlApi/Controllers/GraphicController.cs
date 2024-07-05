using Business.Definitions;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheepControlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphicController : ControllerBase
    {
        IGraphicBusiness _Business;
        IAuthenticationBusiness _AuthenticationBusiness { get; set; }
        public GraphicController(IGraphicBusiness actionBusiness, IAuthenticationBusiness authenticationBusiness)
        {
            _Business = actionBusiness;
            _AuthenticationBusiness = authenticationBusiness;
        }
        // GET: api/<GraphicController>
        [HttpGet("GetDataGraphicSheepPurchaseExpenseProfits")]
        public  async Task<IActionResult> Get()
        {
            var response =await _Business.GetDataGraphicSheepPurchaseExpenseProfits();
            return response.Success ? Ok(response) : StatusCode(response.StatusCode, response);
        }

        // GET api/<GraphicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GraphicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GraphicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GraphicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
