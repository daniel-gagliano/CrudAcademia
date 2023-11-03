using BibliotecaClases;
using Microsoft.EntityFrameworkCore;

namespace CrudAcademia.Context
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base (options) 
        { 
            this.Database.EnsureCreated();
        }
        public DbSet<Persona> Persona{ get; set; }
        public DbSet<Plan>Plan { get; set; }
        public DbSet<Especialidad> Especialidad { get; set;}
        public DbSet<Dictado> Dictados { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Comision> Comisiones { get; set;}
        public DbSet<Inscripcion> Inscripciones { get; set; }
    }
}
