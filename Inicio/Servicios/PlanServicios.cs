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
    public class PlanServicios
    {
        private AcademiaContext dbContext;

        public PlanServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Plan>> ObtenerTodosLosPlanesAsync()
        {
            return await dbContext.Plan.ToListAsync();
        }

        public async Task<Plan> ObtenerPlanPorIdAsync(int id)
        {
            return await dbContext.Plan.FirstOrDefaultAsync(p => p.idPlan == id);
        }

        public async Task AgregarPlanAsync(Plan plan)
        {
            dbContext.Plan.Add(plan);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarPlanAsync(int id, Plan planActualizado)
        {
            var planExistente = await dbContext.Plan.FirstOrDefaultAsync(p => p.idPlan == id);
            if (planExistente != null)
            {
                planExistente.idPlan = planActualizado.idPlan;
                planExistente.descPlan = planActualizado.descPlan;
                planExistente.idEspecialidad = planActualizado.idEspecialidad;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarPlanAsync(int id)
        {
            var planAEliminar = await dbContext.Plan.FirstOrDefaultAsync(x => x.idPlan == id);
            if (planAEliminar != null)
            {
                dbContext.Plan.Remove(planAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
