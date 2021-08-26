using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly MsSqlRepository<Person> _repository;

        public PersonController(MsSqlRepository<Person> repository)
        {
            _repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET: api/[controller]/id
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Person>> Get(Guid id)
        {
            var person = await _repository.Get(id);
            if (person == null) return NotFound();
            return person;
        }

        // PUT: api/[controller]/id
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, Person person)
        {
            if (id != person.Id) return BadRequest();
            await _repository.Update(person);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Person>> Post(Person person)
        {
            await _repository.Add(person);
            return CreatedAtAction("Get", new { id = person.Id }, person);
        }

        // DELETE: api/[controller]/id
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Person>> Delete(Guid id)
        {
            var person = await _repository.Delete(id);
            if (person == null) return NotFound();
            return person;
        }
    }
}