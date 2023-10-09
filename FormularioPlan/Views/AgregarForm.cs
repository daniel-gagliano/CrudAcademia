using BibliotecaClases;
using FormularioPlan.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormularioPersona.Views
{
    public partial class AgregarForm : Form
    {
        public Plan NuevoPlan { get; private set; }

        public AgregarForm(int ultimoId)
        {
            InitializeComponent();
            txtID.Text = (ultimoId).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {

        }

        private void AgregarForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {              
                    int ultimoID = Convert.ToInt32(txtID.Text);
                    String descripcion = txtDescripcion.Text;
                    int IdEspecialidad = Convert.ToInt32(txtEspecialidad.Text);

                //Crear nueva persona
                Plan nuevoPlan = new Plan()
                {
                    
                    descPlan = descripcion,
                    idEspecialidad = IdEspecialidad,
                };
                    NuevoPlan = nuevoPlan;
                    this.Close();
                

            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
