using BibliotecaClases;
using Inicio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Inicio.FormularioEspecialidad
{
    public partial class EditarForm : Form
    {
        private Especialidad especialidadEditar;
        public EditarForm(Especialidad especialidad)
        {
            InitializeComponent();
            this.especialidadEditar = especialidad;
            txtID.Text = (especialidad.idEspecialidad).ToString();
            txtDescripcion.Text = especialidad.descEspecialidad;
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                especialidadEditar.descEspecialidad = txtDescripcion.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                especialidadEditar.descEspecialidad = txtDescripcion.Text;
                EspecialidadServicios.Update(especialidadEditar);
                this.Close();

            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
