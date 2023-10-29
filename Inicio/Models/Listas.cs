using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace FormularioEspecialidad.Models
{
    public class EspecialidadList
    {
        public List<Especialidad> especialidadList { get; set; } = new List<Especialidad>();
    }

    public class PersonaList
    {
        public List<Persona> personaList { get; set; } = new List<Persona>();
    }

    public class PlanList
    {
        public List<Plan> planList { get; set; } = new List<Plan>();
    }
}

