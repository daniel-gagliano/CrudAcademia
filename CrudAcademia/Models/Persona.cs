using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAcademia.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int Id { get; set; }
        public  String apellido { get; set; } 
        public String direccion { get; set; }
        public String nombre { get; set; }
        public String email { get; set;}
        public DateTime? fechaNacimiento { get; set; }
        public int IdPlan { get; set; }
        public int legajo { get; set; }
        public String telefono { get; set; }
        public String tipoPersona { get; set; }
    }
}
