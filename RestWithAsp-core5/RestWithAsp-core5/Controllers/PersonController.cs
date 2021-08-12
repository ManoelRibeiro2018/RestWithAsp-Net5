using Microsoft.AspNetCore.Mvc;
using RestWithAsp_core5.Model;
using RestWithAsp_core5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Controllers
{
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personService;

        public PersonController(IPersonRepository personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person model)
        {
            var person = _personService.Create(model);

            return Created("",person) ;
           // return CreatedAtAction(nameof(GetById), new { person.Id }, person);
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
