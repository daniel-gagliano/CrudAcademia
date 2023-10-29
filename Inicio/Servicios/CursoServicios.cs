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
    public class CursoServicios
    {
        private AcademiaContext dbContext;

        public CursoServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Curso>> ObtenerTodosLosCursosAsync()
        {
            return await dbContext.Cursos.ToListAsync();
        }

        public async Task<Curso> ObtenerCursoPorIdAsync(int id)
        {
            return await dbContext.Cursos.FirstOrDefaultAsync(p => p.idCurso == id);
        }

        public async Task AgregarCursoAsync(Curso curso)
        {
            dbContext.Cursos.Add(curso);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarCursoAsync(int id, Curso cursoActualizado)
        {
            var cursoExistente = await dbContext.Cursos.FirstOrDefaultAsync(p => p.idCurso == id);
            if (cursoExistente != null)
            {
                cursoExistente.idCurso = cursoActualizado.idCurso;
                cursoExistente.idMateria = cursoActualizado.idMateria;
                cursoExistente.idComision = cursoActualizado.idComision;
                cursoExistente.anio = cursoActualizado.anio;
                cursoExistente.cupo = cursoActualizado.cupo;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarCursoAsync(int id)
        {
            var cursoAEliminar = await dbContext.Cursos.FirstOrDefaultAsync(x => x.idCurso == id);
            if (cursoAEliminar != null)
            {
                dbContext.Cursos.Remove(cursoAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
