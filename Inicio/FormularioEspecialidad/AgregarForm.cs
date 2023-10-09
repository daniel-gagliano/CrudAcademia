using BibliotecaClases;
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
    public partial class AgregarForm : Form
    {
        public Especialidad NuevaEspecialidad { get; private set; }
        public AgregarForm(int ultimoId)
        {
            InitializeComponent();
            txtID.Text = (ultimoId).ToString();
        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }

            return true; // Todos los campos son válidos.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {

                String descripcion = txtDescripcion.Text;

                //Crear nueva persona
                Especialidad nuevaEspecialidad = new Especialidad()
                {

                    descEspecialidad = descripcion,

                };
                NuevaEspecialidad = nuevaEspecialidad;
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
