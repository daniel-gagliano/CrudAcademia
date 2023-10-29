using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DictadoController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public DictadoController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Dictado>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Dictados);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Dictado> Get(int id)
        {
            return await _AcademiaContext.Dictados.SingleOrDefaultAsync(x => x.idDictado == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Dictado docenteCurso)
        {
            _AcademiaContext.Dictados.Add(docenteCurso);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dictado docenteCurso)
        {
            var item = _AcademiaContext.Dictados.FirstOrDefault(x => x.idDictado == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Dictados.Update(docenteCurso);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Dictados.FirstOrDefault(x => x.idDictado == id);
            if (item != null)
            {
                _AcademiaContext.Dictados.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
