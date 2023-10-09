using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using FormularioPlan.Models;
using System.Net.Http.Json;
using FormularioPersona.Views;
using BibliotecaClases;

namespace FormularioPersona
{
    public partial class FormPlanes : Form
    {
        private List<Plan> planList = new List<Plan>();
        private Plan nuevoPlan;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7077")
        };

        public FormPlanes()
        {
            InitializeComponent();
            dgvPlanes.CurrentCell = null;
        }

        private void Personas_Load(object sender, EventArgs e)
        {

        }

        protected int ObtenerUltimoId()
        {
            if (planList.Any())
            {
                // Ordena la lista de personas por ID de manera descendente y toma el primer elemento
                Plan ultimoPlan = planList.OrderByDescending(p => p.idPlan).First();
                return ultimoPlan.idPlan;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor inicial
                return 0;
            }
        }



        protected async Task List()
        {
            planList = (await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("api/Plan")).ToList();
            this.dgvPlanes.DataSource = planList;
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
            if (dgvPlanes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvPlanes.SelectedRows[0];

                // El nombre de la columna que contiene el ID es "Id"
                // Acceder al valor del ID de la fila seleccionada:
                String id = selectedRow.Cells["idPlan"].Value.ToString();

                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar este plan?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ahora, la variable 'id' contiene el ID de la fila seleccionada.

                    await _httpClient.DeleteAsync($"api/Plan/{id}");
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
                var response = await _httpClient.GetAsync($"api/Plan/{idRecibido}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    // Verifica si la respuesta es una cadena JSON válida.
                    if (!string.IsNullOrEmpty(jsonResponse) && jsonResponse.StartsWith("{"))
                    {
                        var plan = await response.Content.ReadFromJsonAsync<Plan>();
                        if (plan != null)
                        {
                            List<Plan> planList = new List<Plan> { plan };
                            dgvPlanes.DataSource = planList;

                        }

                    }
                    else
                    {
                        // La respuesta no es un JSON válido, muestra un MessageBox.
                        MessageBox.Show("Plan no encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    // Maneja casos en los que la solicitud no fue exitosa (código de estado HTTP diferente de 200).
                    MessageBox.Show("Ingresa un valor valido", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async void btAgregar_Click(object sender, EventArgs e)
        {
            int ultimoId = ObtenerUltimoId();
            AgregarForm agregar = new AgregarForm(ultimoId + 1);
            agregar.ShowDialog();
            nuevoPlan = agregar.NuevoPlan;
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/Plan", nuevoPlan);
            await this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {

            nuevoPlan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan; ;
            EditarForm editar = new EditarForm(nuevoPlan);
            editar.ShowDialog();
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/Plan/{nuevoPlan.idPlan}", nuevoPlan);

            await this.List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}