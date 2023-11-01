using BibliotecaClases;
using Inicio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Login : Form
    {
        public Usuario Usuario { get; set; }
        public Persona Persona { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (await login())
            {
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
            };
            var user = await UsuarioServicios.Login(credenciales);
            if (user is not null)
            {
                Usuario = user;
                Persona = await PersonaServicios.GetOne(Usuario.idPersona);
                return true;
            }
            else return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
        }

        private void ValidateFields()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsuario.Text)) { btnOK.Enabled = true; }
            else { btnOK.Enabled = false; }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateFields();
        }
    }
}
