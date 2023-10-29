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
    public class DictadoServicios
    {
        private AcademiaContext dbContext;

        public DictadoServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Dictado>> ObtenerTodosLosDictadosAsync()
        {
            return await dbContext.Dictados.ToListAsync();
        }

        public async Task<Dictado> ObtenerDictadoPorIdAsync(int id)
        {
            return await dbContext.Dictados.FirstOrDefaultAsync(p => p.idDictado == id);
        }

        public async Task AgregarDictadoAsync(Dictado dictado)
        {
            dbContext.Dictados.Add(dictado);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarDictadoAsync(int id, Dictado dictadoActualizado)
        {
            var dictadoExistente = await dbContext.Dictados.FirstOrDefaultAsync(p => p.idDictado == id);
            if (dictadoExistente != null)
            {
                dictadoExistente.idDictado = dictadoActualizado.idDictado;
                dictadoExistente.idCurso = dictadoActualizado.idCurso;
                dictadoExistente.idDocente = dictadoActualizado.idDocente;
                dictadoExistente.cargo = dictadoActualizado.cargo;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarDictadoAsync(int id)
        {
            var dictadoAEliminar = await dbContext.Dictados.FirstOrDefaultAsync(x => x.idDictado == id);
            if (dictadoAEliminar != null)
            {
                dbContext.Dictados.Remove(dictadoAEliminar);
                await dbContext.SaveChangesAsync(true);
            }
        }
    }
}
