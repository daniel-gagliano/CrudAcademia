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
    public class UsuarioServicios
    {
        private AcademiaContext dbContext;

        public UsuarioServicios(AcademiaContext context)
        {
            dbContext = context;
        }

        public async Task<List<Usuario>> ObtenerTodosLosUsuariosAsync()
        {
            return await dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> ObtenerUsuarioPorIdAsync(int id)
        {

            return await dbContext.Usuarios.FirstOrDefaultAsync(p => p.idUsuario == id);
        }

        public async Task AgregarUsuarioAsync(Usuario usuario)
        {
            dbContext.Usuarios.Add(usuario);
            await dbContext.SaveChangesAsync();
        }
        public async Task EditarUsuarioAsync(int id, Usuario usuarioActualizado)
        {
            var usuarioExistente = await dbContext.Usuarios.FirstOrDefaultAsync(p => p.idUsuario == id);
            if (usuarioExistente != null)
            {
                usuarioExistente.idUsuario = usuarioActualizado.idUsuario;
                usuarioExistente.idPersona = usuarioActualizado.idPersona;
                usuarioExistente.password = usuarioActualizado.password;
                usuarioExistente.userName = usuarioActualizado.userName;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EliminarUsuarioAsync(int id)
        {
            var usuarioAEliminar = await dbContext.Usuarios.FirstOrDefaultAsync(x => x.idUsuario == id);
            if (usuarioAEliminar != null)
            {
                dbContext.Usuarios.Remove(usuarioAEliminar);
                await dbContext.SaveChangesAsync(true);

            }
        }
    }
}
