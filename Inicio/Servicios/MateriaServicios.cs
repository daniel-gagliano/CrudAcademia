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
    public class MateriaServicios
    {
        private AcademiaContext dbContext;

        public MateriaServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Materia>> ObtenerTodosLasMateriasAsync()
        {
            return await dbContext.Materias.ToListAsync();
        }

        public async Task<Materia> ObtenerMateriaPorIdAsync(int id)
        {
            return await dbContext.Materias.FirstOrDefaultAsync(p => p.idMateria == id);
        }

        public async Task AgregarMateriaAsync(Materia materia)
        {
            dbContext.Materias.Add(materia);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarMateriaAsync(int id, Materia materiaActualizada)
        {
            var materiaExistente = await dbContext.Materias.FirstOrDefaultAsync(p => p.idMateria == id);
            if (materiaExistente != null)
            {
                materiaExistente.idMateria = materiaActualizada.idMateria;
                materiaExistente.idPlan = materiaActualizada.idPlan;
                materiaExistente.descMateria = materiaActualizada.descMateria;
                materiaExistente.hsSemanales = materiaActualizada.hsSemanales;
                materiaExistente.hsTotales = materiaActualizada.hsTotales;


                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarMateriaAsync(int id)
        {
            var materiaAEliminar = await dbContext.Materias.FirstOrDefaultAsync(x => x.idMateria == id);
            if (materiaAEliminar != null)
            {
                dbContext.Materias.Remove(materiaAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
