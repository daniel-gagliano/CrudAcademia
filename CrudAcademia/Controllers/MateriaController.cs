using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MateriaController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public MateriaController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Materia>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Materias);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Materia> Get(int id)
        {
            return await _AcademiaContext.Materias.SingleOrDefaultAsync(x => x.idMateria == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Materia materia)
        {
            _AcademiaContext.Materias.Add(materia);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Materia materia)
        {
            var item = _AcademiaContext.Materias.FirstOrDefault(x => x.idMateria == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Materias.Update(materia);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Materias.FirstOrDefault(x => x.idMateria == id);
            if (item != null)
            {
                _AcademiaContext.Materias.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
