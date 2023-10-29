using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio.Servicios
{    
    public class PersonaServicios
    {
        private AcademiaContext dbContext;

        public PersonaServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Persona>> ObtenerTodasLasPersonasAsync()
        {
            return await dbContext.Persona.ToListAsync();
        }

        public async Task<Persona> ObtenerPersonaPorIdAsync(int id)
        {
            
            return await dbContext.Persona.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AgregarPersonaAsync(Persona persona)
        {
            dbContext.Persona.Add(persona);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarPersonaAsync(int id, Persona personaActualizada)
        {
            var personaExistente = await dbContext.Persona.FirstOrDefaultAsync(p=>p.Id == id);
            if (personaExistente != null)
            {
                personaExistente.Id = personaActualizada.Id;
                personaExistente.apellido = personaActualizada.apellido;
                personaExistente.direccion = personaActualizada.direccion;
                personaExistente.nombre = personaActualizada.nombre;
                personaExistente.email = personaActualizada.email;
                personaExistente.fechaNacimiento = personaActualizada.fechaNacimiento;
                personaExistente.IdPlan = personaActualizada.IdPlan;
                personaExistente.legajo = personaActualizada.legajo;
                personaExistente.telefono = personaActualizada.telefono;
                personaExistente.tipoPersona = personaActualizada.tipoPersona;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarPersonaAsync(int id)
        {
            var personaAEliminar = await dbContext.Persona.FirstOrDefaultAsync(x => x.Id == id);
            if(personaAEliminar != null)
            {
                dbContext.Persona.Remove(personaAEliminar);
                await dbContext.SaveChangesAsync(true);

            }
        }        
    }
}
