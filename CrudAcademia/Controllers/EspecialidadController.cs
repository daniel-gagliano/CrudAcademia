using CrudAcademia.Context;
using CrudAcademia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EspecialidadController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public EspecialidadController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<IEnumerable<Especialidad>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Especialidad);
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<Especialidad> Get(int id)
        {
            return await _AcademiaContext.Especialidad.SingleOrDefaultAsync(x => x.idEspecialidad == id);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] Especialidad especialidad)
        {
        _AcademiaContext.Especialidad.Add(especialidad);
        _AcademiaContext.SaveChanges();
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Especialidad especialidad)
        {
            var item = _AcademiaContext.Especialidad.FirstOrDefault(x=> x.idEspecialidad==id);
            if(item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Especialidad.Update(especialidad);
                _AcademiaContext.SaveChanges();
            }
            
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Especialidad.FirstOrDefault(x=>x.idEspecialidad == id);
            if (item!=null)
            {
                _AcademiaContext.Especialidad.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
