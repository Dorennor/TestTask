using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DbController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public DbController(TRepository repository)
        {
            _repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET: api/[controller]/id
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var person = await _repository.Get(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        // PUT: api/[controller]/id
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, TEntity person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }
            await _repository.Update(person);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity person)
        {
            await _repository.Add(person);
            return CreatedAtAction("Get", new { id = person.Id }, person);
        }

        // DELETE: api/[controller]/id
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var person = await _repository.Delete(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

    }
}
