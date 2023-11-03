using BibliotecaClases;
using Inicio.Servicios;
using System.Text.RegularExpressions;

namespace Inicio.FormularioPersona
{
    public partial class AgregarEditarPersona : Form
    {
        private Persona personaAEditar = null;
        private bool editMode = false;
        public AgregarEditarPersona()
        {
            InitializeComponent();
            CargarPlanes();
            Text = "Agregar persona";
        }

        public AgregarEditarPersona(Persona persona)
        {
            InitializeComponent();
            CargarPlanes();
            Rellenar();
            editMode = true;
            Text = "Editar persona";
            txtId.Visible = true;
            personaAEditar = persona;
            button1.Text = "Guardar";
            button3.Visible = true;
        }

        private void Rellenar()
        {
            txtId.Text = personaAEditar.legajo.ToString();
            txtApellido.Text = personaAEditar.apellido;
            txtNombre.Text = personaAEditar.nombre;
            txtDireccion.Text = personaAEditar.direccion;
            txtEmail.Text = personaAEditar.email;
            txtTelefono.Text = personaAEditar.telefono;
            cmbPlan.Text = personaAEditar.IdPlan.ToString();
            chkAdmin.Checked = personaAEditar.esAdmin;
            chkAlumno.Checked = personaAEditar.esAlumno;
            chkDocente.Checked = personaAEditar.esDocente;
        }

        private async void CargarPlanes()
        {
            // Obtiene las especialidades de la base de datos
            var planes = await PlanServicios.Get();
            // Enlaza la lista de especialidades al ComboBox
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "descPlan"; // Establece la propiedad que se mostrará en el ComboBox
            cmbPlan.ValueMember = "idPLan"; // Establece la propiedad que se utilizará como valor seleccionado
            if (cmbPlan.Items.Count > 0) {cmbPlan.SelectedIndex = 0;} else { cmbPlan.Enabled = false;}
        }

        private bool ValidarCampos()
        {
            if (txtApellido.Text.Length < 2 ||
                txtDireccion.Text.Length < 2 ||
                txtNombre.Text.Length < 2 ||
                ValidarEmail(txtEmail.Text) ||
                cmbPlan.DisplayMember.Length < 2 ||
                txtTelefono.Text.Length < 2 ||
                txtUsuario.Text.Length < 5 ||
                txtContraseña.Text.Length < 5 ||
                (!chkAdmin.Checked && !chkAlumno.Checked && !chkAlumno.Checked) )
            {
                button1.Enabled = false;
                return false; // Al menos uno de los campos está vacío o en blanco.
            }
            button1.Enabled = true;
            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //Crear nueva persona
                Persona nuevaPersona = new Persona()
                {
                    apellido = txtApellido.Text,
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    email = txtEmail.Text,
                    fechaNacimiento = DateTime.Now,
                    IdPlan = (int)cmbPlan.SelectedValue,
                    telefono = txtTelefono.Text,
                    userName = txtUsuario.Text,
                    password = txtContraseña.Text,
                    esAdmin = chkAdmin.Checked,
                    esAlumno = chkAlumno.Checked,
                    esDocente = chkDocente.Checked,
                };
                if (editMode)
                {
                    var ok = await PersonaServicios.Update(nuevaPersona);
                    if (ok) { this.Close(); }
                }
                else
                {
                    var personaAdded = await PersonaServicios.Create(nuevaPersona);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = false;
            }
            else
            {
                lblErrorEmail.Visible = true;
            }
        }
        private bool ValidarEmail(string email)
        {
            if (email.Length == 0) return false;
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, patron);
        }
        private void txtOnlyAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private async void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && !(await PersonaServicios.UsuarioDisponible(txtUsuario.Text)))
            {
                lblErrUser.Visible = true;
            }
            else
            {
                lblErrUser.Visible = false;
            }
        }
    }
}
