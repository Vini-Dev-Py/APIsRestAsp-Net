using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestApisWithAspNet.Model;
using RestApisWithAspNet.Services;

namespace RestApisWithAspNet.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet("index/")]
        public IActionResult GetIndex()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("index/{id}")]
        public IActionResult GetPersonByID(long id)
        {
            var person = _personService.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost("index/")]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut("index/{id}")]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        

        [HttpDelete("index/{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);

            return Ok($"Person number {id} successfully deleted");
        }
    }
}
