using BibliotecaClases;
using Inicio.Servicios;
namespace Inicio
{
    public partial class Login : Form
    {
        public Persona? Persona { get; private set; }
        public string tipoIngreso { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (!await login())
            {
                tipoIngreso = cmbLoginAs.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPw.Checked;
        }
        private async Task<bool> login()
        {
            var credenciales = new Credenciales()
            {
                userName = txtUsuario.Text,
                password = txtPassword.Text,
                loguearComo = cmbLoginAs.Text,
            };
            var prsn = await PersonaServicios.Login(credenciales);
            if (prsn is not null)
            {
                Persona = prsn;
                return true;
            }
            else return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            cmbLoginAs.SelectedIndex = 0;
        }

        private void ValidateFields()
        {
            if (txtPassword.Text.Length >= 4 && txtUsuario.Text.Length >= 4) { btnOK.Enabled = true; }
            else { btnOK.Enabled = false; }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateFields();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Form? form = null;
                switch (this.tipoIngreso)
                {
                    case "Alumno":
                        Application.Exit();
                        break;
                    case "Administrador":
                        form = new Inicio();
                        break;
                    case "Docente":
                        Application.Exit();
                        break;
                    default:
                        Application.Exit();
                        break;
                }
                form.MdiParent = this.MdiParent;
                this.Dispose();
                form.Show();
            }
            else Application.Exit();
        }
    }
}
