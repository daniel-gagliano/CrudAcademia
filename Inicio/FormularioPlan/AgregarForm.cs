using BibliotecaClases;
using CrudAcademia.Context;
using Inicio.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.FormularioPlan
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
            CargarEspecialidad();
        }

        private async void CargarEspecialidad()
        {
            var especialidades = await EspecialidadServicios.Get();
            txtEspecialidad.DataSource = especialidades;
            txtEspecialidad.DisplayMember = "descEspecialidad"; // Establece la propiedad que se mostrará en el ComboBox
            txtEspecialidad.ValueMember = "idEspecialidad"; // Establece la propiedad que se utilizará como valor seleccionado
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {
                //Crear nueva persona
                Plan nuevoPlan = new Plan()
                {

                    descPlan = txtDescripcion.Text,
                    idEspecialidad = (int)txtEspecialidad.SelectedValue,
                };
                await PlanServicios.Create(nuevoPlan);
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
