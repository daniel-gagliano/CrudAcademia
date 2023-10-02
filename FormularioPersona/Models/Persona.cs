using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioPersona.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
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
}
