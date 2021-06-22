using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestApisWithAspNet.Model;
using RestApisWithAspNet.Business;

namespace RestApisWithAspNet.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet("index/")]
        public IActionResult GetIndex()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("index/{id}")]
        public IActionResult GetPersonByID(long id)
        {
            var person = _personBusiness.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost("index/")]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personBusiness.Create(person));
        }

        [HttpPut("index/{id}")]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personBusiness.Update(person));
        }

        

        [HttpDelete("index/{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);

            return Ok($"Person number {id} successfully deleted");

        }
    }
}
