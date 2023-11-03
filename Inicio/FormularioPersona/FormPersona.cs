using BibliotecaClases;
using Inicio.Servicios;
using System.Windows.Forms;

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
            if (dgvPersonas.Rows.Count == 0)
            {
                btEliminar.Enabled = false;
                btEditar.Enabled = false;
            }
            else
            {
                btEliminar.Enabled = true;
                btEditar.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarPersona agregar = new AgregarEditarPersona();
            agregar.ShowDialog();
            this.List();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            var editPersona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona;
            AgregarEditarPersona agregar = new AgregarEditarPersona(editPersona);
            agregar.ShowDialog();
            this.List();

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
