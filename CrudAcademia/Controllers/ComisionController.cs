using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ComisionController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public ComisionController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Comision>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Comisiones);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Comision> Get(int id)
        {
            return await _AcademiaContext.Comisiones.SingleOrDefaultAsync(x => x.idComision == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Comision comision)
        {
            _AcademiaContext.Comisiones.Add(comision);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Comision comision)
        {
            var item = _AcademiaContext.Comisiones.FirstOrDefault(x => x.idComision == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Comisiones.Update(comision);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Comisiones.FirstOrDefault(x => x.idComision == id);
            if (item != null)
            {
                _AcademiaContext.Comisiones.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }
    }
}
