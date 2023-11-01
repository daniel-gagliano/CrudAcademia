using Inicio.FormularioEspecialidad;
using Inicio.FormularioMateria;
using Inicio.FormularioPersona;
using Inicio.FormularioPlan;
using BibliotecaClases;

namespace Inicio
{
    public partial class Inicio : Form
    {
        public Inicio(Usuario usuario, Persona persona)
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            FormPersona personasCrud = new FormPersona();
            personasCrud.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPlan planesCrud = new FormPlan();
            planesCrud.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEspecialidad especialidadesCrud = new FormEspecialidad();
            especialidadesCrud.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMateria materiasCrud = new FormMateria();
            materiasCrud.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}