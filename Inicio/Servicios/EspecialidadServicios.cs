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
    public class EspecialidadServicios
    {
        private AcademiaContext dbContext;

        public EspecialidadServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Especialidad>> ObtenerTodasLasEspecialidadesAsync()
        {
            return await dbContext.Especialidad.ToListAsync();
        }

        public async Task<Especialidad> ObtenerEspecialidadPorIdAsync(int id)
        {

            return await dbContext.Especialidad.FirstOrDefaultAsync(p => p.idEspecialidad == id);
        }

        public async Task AgregarEspecialidadAsync(Especialidad especialidad)
        {
            dbContext.Especialidad.Add(especialidad);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarEspecialidadAsync(int id, Especialidad especialidadActualizada)
        {
            var especialidadExistente = await dbContext.Especialidad.FirstOrDefaultAsync(p => p.idEspecialidad == id);
            if (especialidadExistente != null)
            {
                especialidadExistente.idEspecialidad = especialidadActualizada.idEspecialidad;
                especialidadExistente.descEspecialidad = especialidadActualizada.descEspecialidad;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarEspecialidadAsync(int id)
        {
            var especialidadAEliminar = await dbContext.Especialidad.FirstOrDefaultAsync(x => x.idEspecialidad == id);
            if (especialidadAEliminar != null)
            {
                dbContext.Especialidad.Remove(especialidadAEliminar);
                await dbContext.SaveChangesAsync(true);

            }
        }
    }
}
