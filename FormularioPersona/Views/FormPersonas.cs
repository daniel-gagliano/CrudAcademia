using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using FormularioPersona.Models;
using System.Net.Http.Json;
using FormularioPersona.Views;
using BibliotecaClases;

namespace FormularioPersona
{
    public partial class FormPersonas : Form
    {
        private List<Persona> personaList = new List<Persona>();
        private Persona nuevaPersona;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7077")
        };

        public FormPersonas()
        {
            InitializeComponent();
            dgvPersonas.CurrentCell = null;
        }

        private void Personas_Load(object sender, EventArgs e)
        {

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
                // Si la lista est� vac�a, devuelve un valor inicial
                return 0;
            }
        }



        protected async Task List()
        {
            personaList = (await _httpClient.GetFromJsonAsync<IEnumerable<Persona>>("api/Persona")).ToList();
            this.dgvPersonas.DataSource = personaList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void FormPersonas_Load(object sender, EventArgs e)
        {
            await this.List();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvPersonas.SelectedRows[0];

                // El nombre de la columna que contiene el ID es "Id"
                // Acceder al valor del ID de la fila seleccionada:
                String id = selectedRow.Cells["Id"].Value.ToString();

                // Mostrar un MessageBox de confirmaci�n
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta persona?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ahora, la variable 'id' contiene el ID de la fila seleccionada.

                    await _httpClient.DeleteAsync($"api/Persona/{id}");
                }


            }

            await this.List();
        }

        private async void btConsultar_Click(object sender, EventArgs e)
        {
            BusquedaForm busqueda = new BusquedaForm();
            busqueda.ShowDialog();
            String idRecibido = busqueda.id;

            if (!string.IsNullOrEmpty(idRecibido))
            {
                var response = await _httpClient.GetAsync($"api/Persona/{idRecibido}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    // Verifica si la respuesta es una cadena JSON v�lida.
                    if (!string.IsNullOrEmpty(jsonResponse) && jsonResponse.StartsWith("{"))
                    {
                        var persona = await response.Content.ReadFromJsonAsync<Persona>();
                        if (persona != null)
                        {
                            List<Persona> personaList = new List<Persona> { persona };
                            dgvPersonas.DataSource = personaList;

                        }

                    }
                    else
                    {
                        // La respuesta no es un JSON v�lido, muestra un MessageBox.
                        MessageBox.Show("Persona no encontrada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    // Maneja casos en los que la solicitud no fue exitosa (c�digo de estado HTTP diferente de 200).
                    MessageBox.Show("Ingresa un valor valido", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async void btAgregar_Click(object sender, EventArgs e)
        {
            int ultimoId = ObtenerUltimoId();
            AgregarForm agregar = new AgregarForm(ultimoId + 1);
            agregar.ShowDialog();
            nuevaPersona = agregar.NuevaPersona;
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/Persona", nuevaPersona);
            await this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {

            nuevaPersona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona; ;
            EditarForm editar = new EditarForm(nuevaPersona);
            editar.ShowDialog();
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/Persona/{nuevaPersona.Id}", nuevaPersona);

            await this.List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}