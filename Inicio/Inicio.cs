using FormularioPersona;
using FormularioPlan;
using FormularioEspecialidad;

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
            FormPersonas personasCrud = new FormPersonas();
            personasCrud.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPlanes planesCrud = new FormPlanes();
            planesCrud.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEspecialidades especialidadesCrud = new FormEspecialidades();
            especialidadesCrud.ShowDialog();
        }
    }
}