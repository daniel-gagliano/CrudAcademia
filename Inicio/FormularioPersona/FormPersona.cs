using BibliotecaClases;
using CrudAcademia.Context;
using Inicio.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.FormularioPersona
{
    public partial class FormPersona : Form
    {
        private List<Persona> personaList = new List<Persona>();

        public FormPersona()
        {
            InitializeComponent();


            this.List();
            
        }
        private async void List()
        {
            var personas = await PersonaServicios.Get();
            dgvPersonas.DataSource = personas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.List();
        }

        private async void btConsultar_Click(object sender, EventArgs e)
        {
            BusquedaForm busqueda = new BusquedaForm();
            busqueda.ShowDialog();
            if (busqueda.DialogResult == DialogResult.OK)
            {
                if (int.TryParse(busqueda.id, out int idRecibido) && idRecibido > 0)
                {                
                    var persona = await PersonaServicios.GetOne(idRecibido);

                    if (persona != null)
                    {
                        List<Persona> personaList = new List<Persona> { persona };
                        dgvPersonas.DataSource = personaList;
                    }
                    else
                    {
                        MessageBox.Show("Persona no encontrada", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa un valor válido", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarForm agregar = new AgregarForm();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var editPersona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona;
            EditarForm editar = new EditarForm(editPersona);
            editar.ShowDialog();    

            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {                
                int personaId = (int)dgvPersonas.SelectedRows[0].Cells[0].Value;                
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta persona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {                
                 await PersonaServicios.Delete(personaId);
                }

            }
            this.List();
        }
    }
}
