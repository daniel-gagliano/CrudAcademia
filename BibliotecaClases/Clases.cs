using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BibliotecaClases
{
    public class Especialidad
    {    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idEspecialidad { get; set; }
        public string descEspecialidad { get; set; }
    }

    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int Id { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String nombre { get; set; }
        public String email { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public int IdPlan { get; set; }
        public int legajo { get; set; }
        public String telefono { get; set; }
        public String tipoPersona { get; set; }
    }
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idPlan { get; set; }
        public string descPlan { get; set; }
        public int idEspecialidad { get; set; }
    }
}
