using BibliotecaClases;
using Inicio.Servicios;

namespace Inicio.FormularioPersona
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();


            this.List();
            
        }
        private async void List()
        {
            dgvPersonas.DataSource = await PersonaServicios.Get();
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
            int idRecibido = int.Parse(busqueda.id);

            if (idRecibido != 0)
            {
                var persona = await PersonaServicios.GetOne(idRecibido);

                if (persona is not null)
                {
                    dgvPersonas.DataSource = persona;
                }
                else
                {
                    MessageBox.Show("Persona no encontrada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarForm agregar = new AgregarForm();
            agregar.ShowDialog();
            this.List();
        }

        private void btEditar_Click(object sender, EventArgs e)
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
