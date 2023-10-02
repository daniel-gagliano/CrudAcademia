using CrudAcademia.Models;
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
    }
}
