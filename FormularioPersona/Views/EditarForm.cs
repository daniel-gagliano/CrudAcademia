﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;
using FormularioPersona.Models;

namespace FormularioPersona.Views
{
    public partial class EditarForm : Form
    {
        private Persona personaAEditar;
        public EditarForm(Persona persona)
        {
            InitializeComponent();
            this.personaAEditar = persona;
            txtApellido.Text = persona.apellido;
            txtNombre.Text = persona.nombre;
            txtDireccion.Text = persona.direccion;
            txtEmail.Text = persona.email;
            txtTelefono.Text = persona.telefono;
            txtTipoPersona.Text = persona.tipoPersona;
            txtIdPlan.Text = persona.IdPlan.ToString();
            txtLegajo.Text = persona.legajo.ToString();
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
            if (ValidarCampos())
            {
                if (int.TryParse(txtLegajo.Text, out int legajoOk))
                {
                    personaAEditar.email = txtEmail.Text;
                    personaAEditar.apellido = txtApellido.Text;
                    personaAEditar.nombre = txtNombre.Text;
                    personaAEditar.tipoPersona = txtTipoPersona.Text;
                    personaAEditar.telefono = txtTelefono.Text;
                    personaAEditar.direccion = txtDireccion.Text;
                    personaAEditar.IdPlan = Convert.ToInt32(txtIdPlan.Text);
                    personaAEditar.legajo = Convert.ToInt32(txtLegajo.Text);
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
    }
}
