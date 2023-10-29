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
    public class ComisionServicios
    {
        private AcademiaContext dbContext;

        public ComisionServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Comision>> ObtenerTodosLasComisionesAsync()
        {
            return await dbContext.Comisiones.ToListAsync();
        }

        public async Task<Comision> ObtenerComisionPorIdAsync(int id)
        {
            return await dbContext.Comisiones.FirstOrDefaultAsync(p => p.idComision == id);
        }

        public async Task AgregarComisionAsync(Comision comision)
        {
            dbContext.Comisiones.Add(comision);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarComisionAsync(int id, Comision comisionActualizada)
        {
            var comisionExistente = await dbContext.Comisiones.FirstOrDefaultAsync(p => p.idComision == id);
            if (comisionExistente != null)
            {
                comisionExistente.idComision = comisionActualizada.idComision;
                comisionExistente.descComision = comisionActualizada.descComision;
                comisionExistente.anioEspecialidad = comisionActualizada.anioEspecialidad;
                comisionExistente.idPlan = comisionActualizada.idPlan;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarComisionAsync(int id)
        {
            var comisionAEliminar = await dbContext.Comisiones.FirstOrDefaultAsync(x => x.idComision == id);
            if (comisionAEliminar != null)
            {
                dbContext.Comisiones.Remove(comisionAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
