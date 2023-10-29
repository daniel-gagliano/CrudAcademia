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
    public class InscripcionServicios
    {
        private AcademiaContext dbContext;

        public InscripcionServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Inscripcion>> ObtenerTodasLasInscripcionesAsync()
        {
            return await dbContext.Inscripciones.ToListAsync();
        }

        public async Task<Inscripcion> ObtenerInscripcionPorIdAsync(int id)
        {
            return await dbContext.Inscripciones.FirstOrDefaultAsync(p => p.idInscripcion == id);
        }

        public async Task AgregarInscripcionAsync(Inscripcion inscripcion)
        {
            dbContext.Inscripciones.Add(inscripcion);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarInscripcionAsync(int id, Inscripcion inscripcionActualizada)
        {
            var inscripcionExistente = await dbContext.Inscripciones.FirstOrDefaultAsync(p => p.idInscripcion == id);
            if (inscripcionExistente != null)
            {
                inscripcionExistente.idInscripcion = inscripcionActualizada.idInscripcion;
                inscripcionExistente.idAlumno = inscripcionActualizada.idAlumno;
                inscripcionExistente.idCurso = inscripcionActualizada.idCurso;
                inscripcionExistente.condicion = inscripcionActualizada.condicion;
                inscripcionExistente.nota = inscripcionActualizada.nota;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarInscripcionAsync(int id)
        {
            var inscripcionAEliminar = await dbContext.Inscripciones.FirstOrDefaultAsync(x => x.idInscripcion == id);
            if (inscripcionAEliminar != null)
            {
                dbContext.Inscripciones.Remove(inscripcionAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
