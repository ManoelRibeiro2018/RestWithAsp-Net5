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
          
            var person = _personService.Create(model);

            return Created("",person) ;
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person model)
        {


            var person = _personService.Update(model, id);

            return Ok(person);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _personService.Delete(id);
            return Ok();
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
