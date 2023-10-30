using Inicio.FormularioEspecialidad;
using Inicio.FormularioPlan;
using Inicio.FormularioPersona;

namespace Inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
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

        }
    }
}