using FormularioPersona.Models;
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
        public Persona NuevaPersona { get; private set; }

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
                if (int.TryParse(txtLegajo.Text, out int legajoOk))
                {
                    int ultimoID = Convert.ToInt32(txtID.Text);
                    String apellido = txtApellido.Text;
                    String direccion = txtDireccion.Text;
                    String nombre = txtNombre.Text;
                    String email = txtEmail.Text;
                    DateTime fechaNacimiento = DateTime.Now;
                    int IdPlan = Convert.ToInt32(txtIdPlan.Text);
                    int legajo = Convert.ToInt32(txtLegajo.Text);
                    String telefono = txtTelefono.Text;
                    String tipoPersona = txtTipoPersona.Text;

                    //Crear nueva persona
                    Persona nuevaPersona = new Persona()
                    {
                        Id = ultimoID,
                        apellido = apellido,
                        nombre = nombre,
                        direccion = direccion,
                        email = email,
                        fechaNacimiento = fechaNacimiento,
                        IdPlan = IdPlan,
                        legajo = legajo,
                        telefono = telefono,
                        tipoPersona = tipoPersona,
                    };
                    NuevaPersona = nuevaPersona;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El campo 'Legajo' debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIdPlan.Text) || string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtTipoPersona.Text))
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
