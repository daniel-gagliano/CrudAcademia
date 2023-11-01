using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudAcademia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    {
        private readonly AcademiaContext _AcademiaContext;

        public UsuarioController(AcademiaContext AcademiaContext)
        {
            _AcademiaContext = AcademiaContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Usuario>> GetAsync()
        {
            return await Task.FromResult(_AcademiaContext.Usuarios);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<Usuario> Get(int id)
        {
            return await _AcademiaContext.Usuarios.SingleOrDefaultAsync(x => x.idUsuario == id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            _AcademiaContext.Usuarios.Add(usuario);
            _AcademiaContext.SaveChanges();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Usuario usuario)
        {
            var item = _AcademiaContext.Usuarios.FirstOrDefault(x => x.idUsuario == id);
            if (item != null)
            {
                _AcademiaContext.Entry(item).State = EntityState.Detached;
                _AcademiaContext.Usuarios.Update(usuario);
                _AcademiaContext.SaveChanges();
            }

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _AcademiaContext.Usuarios.FirstOrDefault(x => x.idUsuario == id);
            if (item != null)
            {
                _AcademiaContext.Usuarios.Remove(item);
                _AcademiaContext.SaveChanges();
            }
        }

        [HttpPost("autenticar")]
        public async Task<ActionResult<Usuario>> AutenticarUsuario([FromBody] Credenciales credenciales)
        {
            var usuario = await _AcademiaContext.Usuarios
                .SingleOrDefaultAsync(x => x.userName == credenciales.userName && x.password == credenciales.password);
            return usuario;
        }
    }
}
