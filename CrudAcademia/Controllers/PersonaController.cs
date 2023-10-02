using CrudAcademia.Context;
using CrudAcademia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PersonaController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public PersonaController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<IEnumerable<Persona>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Persona);
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<Persona> Get(int id)
        {
            return await _AcademiaContext.Persona.SingleOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] Persona persona)
        {
        _AcademiaContext.Persona.Add(persona);
        _AcademiaContext.SaveChanges();
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Persona persona)
        {
            var item = _AcademiaContext.Persona.FirstOrDefault(x=> x.Id==id);
            if(item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Persona.Update(persona);
                _AcademiaContext.SaveChanges();
            }
            
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Persona.FirstOrDefault(x=>x.Id==id);
            if (item!=null)
            {
                _AcademiaContext.Persona.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
