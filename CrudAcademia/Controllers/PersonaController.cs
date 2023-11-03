using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaClases;
using CrudAcademia.Context;

namespace CrudAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly AcademiaContext _context;
        const string administrador = "Administrador";
        const string docente = "Docente";
        const string alumno = "Alumno";

        public PersonaController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersona(string? rol="")
        {
          if (_context.Persona == null)
          {
              return NotFound();
          }
            if (!string.IsNullOrEmpty(rol))
            {
                switch (rol)
                {
                    case administrador:
                        return await _context.Persona.Where(u => u.esAdmin).ToListAsync();
                    case docente:
                        return await _context.Persona.Where(u => u.esDocente).ToListAsync();
                    case alumno:
                        return await _context.Persona.Where(u => u.esAlumno).ToListAsync();
                    default:
                        return BadRequest();
                }
            }
            else return await _context.Persona.ToListAsync();
        }

        // GET: api/Persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
          if (_context.Persona == null)
          {
              return NotFound();
          }
            var persona = await _context.Persona.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return persona;
        }

        // PUT: api/Persona/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersona(int id, Persona persona)
        {
            if (id != persona.legajo)
            {
                return BadRequest();
            }

            _context.Entry(persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Persona
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
          if (_context.Persona == null)
          {
              return Problem("Entity set 'AcademiaContext.Persona'  is null.");
          }
            _context.Persona.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.legajo }, persona);
        }

        // DELETE: api/Persona/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(int legajo)
        {
            var persona = await _context.Persona.FindAsync(legajo);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool PersonaExists(int id)
        {
            return (_context.Persona?.Any(e => e.legajo == id)).GetValueOrDefault();
        }

        [HttpPost("autenticar")]
        public async Task<ActionResult<Persona>> AutenticarUsuario([FromBody] Credenciales credenciales)
        {
            Persona persona;
            switch (credenciales.loguearComo)
            {
                case administrador:
                    persona = await _context.Persona
                        .SingleOrDefaultAsync(x => x.userName == credenciales.userName && x.password == credenciales.password && x.esAdmin);
                    break;
                case docente:
                    persona = await _context.Persona
                        .SingleOrDefaultAsync(x => x.userName == credenciales.userName && x.password == credenciales.password && x.esDocente);
                    break;
                case alumno:
                    persona = await _context.Persona
                        .SingleOrDefaultAsync(x => x.userName == credenciales.userName && x.password == credenciales.password && x.esAlumno);
                    break;
                default:
                    persona = null;
                    break;
            }
            return persona;
        }

        [HttpPost("usuariodisponible")]
        public async Task<IActionResult> ValidarUsuarioDisponible([FromBody] string nombreUsuario)
        {
            var persona = await _context.Persona.SingleOrDefaultAsync(x => x.userName == nombreUsuario);
            if (persona is null)
            {
                return Ok(true); // El nombre de usuario está disponible.
            }
            else
            {
                return Conflict("El nombre de usuario no está disponible."); // El nombre de usuario no está disponible.
            }
        }

    }
}
