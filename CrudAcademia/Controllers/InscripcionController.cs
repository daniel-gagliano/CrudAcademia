using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class InscripcionController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public InscripcionController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Inscripcion>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Inscripciones);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Inscripcion> Get(int id)
        {
            return await _AcademiaContext.Inscripciones.SingleOrDefaultAsync(x => x.idInscripcion == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Inscripcion inscripcion)
        {
            _AcademiaContext.Inscripciones.Add(inscripcion);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Inscripcion inscripcion)
        {
            var item = _AcademiaContext.Inscripciones.FirstOrDefault(x => x.idInscripcion == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Inscripciones.Update(inscripcion);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Inscripciones.FirstOrDefault(x => x.idInscripcion == id);
            if (item != null)
            {
                _AcademiaContext.Inscripciones.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
