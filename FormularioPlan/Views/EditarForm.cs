using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;
using FormularioPlan.Models;


namespace FormularioPersona.Views
{
    public partial class EditarForm : Form
    {
        private Plan planEditar;
        public EditarForm(Plan plan)
        {
            InitializeComponent();
            this.planEditar = plan;
            txtDescripcion.Text = plan.descPlan;
            txtID.Text = plan.idPlan.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                planEditar.descPlan = txtDescripcion.Text;
                planEditar.idEspecialidad = Convert.ToInt32(txtEspecialidad.Text);
                this.Close();




            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
