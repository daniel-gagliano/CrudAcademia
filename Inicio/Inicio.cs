using Inicio.FormularioEspecialidad;
using Inicio.FormularioMateria;
using Inicio.FormularioPersona;
using Inicio.FormularioPlan;
using BibliotecaClases;
using System.Windows.Forms;

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
            FormMateria materiasCrud = new FormMateria();
            materiasCrud.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
            {
                var login = new Login();
                login.MdiParent = this.MdiParent;
                login.StartPosition = FormStartPosition.Manual;
                login.Location = new Point(
                    MdiParent.Location.X + (MdiParent.Width - login.Width) / 2,
                    MdiParent.Location.Y + (MdiParent.Height - login.Height) / 2
                );
                this.Dispose();
                login.Show();
            }
        }
    }
}