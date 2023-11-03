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
        public int legajo { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String nombre { get; set; }
        public String email { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public int IdPlan { get; set; }
        [Index(IsUnique = true)]
        public String telefono { get; set; }
        public String tipoPersona { get; set; }
        [Index(IsUnique = true)]
        public String userName { get; set; }
        public String password { get; set; }
        public bool esAdmin { get; set; } = false;
        public bool esAlumno { get; set; } = false;
        public bool esDocente { get; set; } = false;
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

    //Docente_Curso
    public class Dictado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idDictado { get; set; }
        public int idCurso { get; set; }
        public int idDocente { get; set; }
        public String cargo { get; set; }
    }

    public class Curso 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idCurso { get; set;}
        public int idMateria { get; set;}
        public int idComision { get; set; }
        public int anio { get; set;}
        public int cupo { get; set; }

    }

    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idMateria { get; set; }
        public String descMateria { get; set; }
        public int hsSemanales { get; set; }
        public int hsTotales { get; set; }
        public int idPlan { get; set; }
    }

    public class Comision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idComision { get; set;}
        public String descComision { get; set; }
        public int anioEspecialidad { get; set; }
        public int idPlan { get; set; }
    }

   //Alumno_Curso
    public class Inscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int idInscripcion { get; set; }
        public int idAlumno { get; set; }
        public int idCurso { get; set; }
        public String condicion { get; set; }
        public int nota { get; set; }
    }

    public class Credenciales
    {
        public String userName { get; set; }
        public String password { get; set; }
        public String loguearComo { get; set; }
    }

}
