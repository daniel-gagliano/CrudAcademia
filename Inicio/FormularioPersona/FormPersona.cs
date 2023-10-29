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
        private DbContextOptionsBuilder<AcademiaContext> optionsBuilder;
        private AcademiaContext dbContext;
        private PersonaServicios personaServicios;
        private UsuarioServicios usuarioServicios;
        private List<Persona> personaList = new List<Persona>();
        private Persona nuevaPersona;
        private Usuario nuevoUsuario;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7077")
        };

        public FormPersona()
        {
            InitializeComponent();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("dbAcademia");

            optionsBuilder = new DbContextOptionsBuilder<AcademiaContext>();
            optionsBuilder.UseSqlServer(connectionString);
            dbContext = new AcademiaContext(optionsBuilder.Options);

            personaServicios = new PersonaServicios(dbContext);
            usuarioServicios = new UsuarioServicios(dbContext);


            this.List();
            
        }
        protected int ObtenerUltimoId()
        {
            if (personaList.Any())
            {
                // Ordena la lista de personas por ID de manera descendente y toma el primer elemento
                Persona ultimaPersona = personaList.OrderByDescending(p => p.Id).First();
                return ultimaPersona.Id;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor inicial
                return 0;
            }
        }
        private async void List()
        {
            var personas = await personaServicios.ObtenerTodasLasPersonasAsync();
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
                    var persona = await personaServicios.ObtenerPersonaPorIdAsync(idRecibido);

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
            int ultimoId = ObtenerUltimoId();
            AgregarForm agregar = new AgregarForm(ultimoId + 1,personaServicios,usuarioServicios);
            agregar.ShowDialog();
            nuevaPersona = agregar.NuevaPersona;
            nuevoUsuario = agregar.NuevoUsuario;
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            nuevaPersona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona; ;
            EditarForm editar = new EditarForm(nuevaPersona,personaServicios);
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
                 await personaServicios.EliminarPersonaAsync(personaId);
                }

            }
            this.List();
        }
    }
}
