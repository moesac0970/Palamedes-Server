using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    public class ControllerCrudBase<T, R> : ControllerBase
        where T : EntityBase
        where R : Repository<T>
    {
        protected R repository;
        public ControllerCrudBase(R r)
        {
            repository = r;
        }

        // GET: T
        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var cumquat = await repository.ListAll();
            return Ok(await repository.ListAll());
        }

        // GET: T/2
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(long id)
        {
            return Ok(await repository.GetById(id));
        }

        // PUT: T/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] long id,
            [FromBody] T entity)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != entity.Id) return BadRequest();

            T updated = await repository.Update(entity);

            if (updated == null) return NotFound();
            return Ok(updated);
        }

        // POST: T
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T entity)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await repository.Add(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: T/3
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var deleted = await repository.Delete(id);
            if (deleted == null) return NotFound();
            return Ok(deleted);
        }
    }
}
