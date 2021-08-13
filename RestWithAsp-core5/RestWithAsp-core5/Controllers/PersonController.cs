using Microsoft.AspNetCore.Mvc;
using RestWithAsp_core5.Model;
using RestWithAsp_core5.Services;
using System.Linq;

namespace RestWithAsp_core5.Controllers
{
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person model)
        {
            if (!ModelState.IsValid)
            {
                var msg = ModelState.SelectMany(erro => erro.Value.Errors).Select(msg => msg.ErrorMessage);
                return BadRequest(msg);
            }
            var person = _personService.Create(model);

            return Created("",person) ;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            var persons = _personService.FindAll();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var person = _personService.FindById(id);
            return Ok(person);
        }

    }
}
