using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using FormularioEspecialidad.Models;
using System.Net.Http.Json;
using FormularioPersona.Views;
using BibliotecaClases;

namespace FormularioPersona
{
    public partial class FormEspecialidades : Form
    {
        private List<Especialidad> especialidadList = new List<Especialidad>();
        private Especialidad nuevaEspecialidad;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7077")
        };

        public FormEspecialidades()
        {
            InitializeComponent();
            dgvEspecialidades.CurrentCell = null;
        }

        private void Personas_Load(object sender, EventArgs e)
        {

        }

        protected int ObtenerUltimoId()
        {
            if (especialidadList.Any())
            {
                // Ordena la lista de personas por ID de manera descendente y toma el primer elemento
                Especialidad ultimaEspecialidad = especialidadList.OrderByDescending(p => p.idEspecialidad).First();
                return ultimaEspecialidad.idEspecialidad;
            }
            else
            {
                // Si la lista est� vac�a, devuelve un valor inicial
                return 0;
            }
        }



        protected async Task List()
        {
            especialidadList = (await _httpClient.GetFromJsonAsync<IEnumerable<Especialidad>>("api/Especialidad")).ToList();
            this.dgvEspecialidades.DataSource = especialidadList;
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
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvEspecialidades.SelectedRows[0];

                // El nombre de la columna que contiene el ID es "Id"
                // Acceder al valor del ID de la fila seleccionada:
                String id = selectedRow.Cells["idEspecialidad"].Value.ToString();

                // Mostrar un MessageBox de confirmaci�n
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta especialidad?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ahora, la variable 'id' contiene el ID de la fila seleccionada.

                    await _httpClient.DeleteAsync($"api/Especialidad/{id}");
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
                var response = await _httpClient.GetAsync($"api/Especialidad/{idRecibido}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    // Verifica si la respuesta es una cadena JSON v�lida.
                    if (!string.IsNullOrEmpty(jsonResponse) && jsonResponse.StartsWith("{"))
                    {
                        var especialidad = await response.Content.ReadFromJsonAsync<Especialidad>();
                        if (especialidad != null)
                        {
                            List<Especialidad> especialidadList = new List<Especialidad> { especialidad };
                            dgvEspecialidades.DataSource = especialidadList;

                        }

                    }
                    else
                    {
                        // La respuesta no es un JSON v�lido, muestra un MessageBox.
                        MessageBox.Show("Especialidad no encontrada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            nuevaEspecialidad = agregar.NuevaEspecialidad;
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/Especialidad", nuevaEspecialidad);
            await this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {

            nuevaEspecialidad = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad; ;
            EditarForm editar = new EditarForm(nuevaEspecialidad);
            editar.ShowDialog();
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/Especialidad/{nuevaEspecialidad.idEspecialidad}", nuevaEspecialidad);

            await this.List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}