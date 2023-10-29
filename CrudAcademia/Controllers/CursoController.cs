using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CursoController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public CursoController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Curso>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Cursos);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Curso> Get(int id)
        {
            return await _AcademiaContext.Cursos.SingleOrDefaultAsync(x => x.idCurso == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Curso curso)
        {
            _AcademiaContext.Cursos.Add(curso);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Curso curso)
        {
            var item = _AcademiaContext.Cursos.FirstOrDefault(x => x.idCurso == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Cursos.Update(curso);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Cursos.FirstOrDefault(x => x.idCurso == id);
            if (item != null)
            {
                _AcademiaContext.Cursos.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
