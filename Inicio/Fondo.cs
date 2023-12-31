﻿using System;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Fondo : Form
    {
        public Fondo()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        public void IniciarAplicacion()
        {
            var loginForm = new Login();
            AbrirNuevoForm(loginForm);
        }

        private async void Fondo_Load(object sender, EventArgs e)
        {
            IniciarAplicacion();
        }

        private async void AbrirNuevoForm(Form formulario)
        {
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.Location = new Point(
                this.Location.X + (this.Width - formulario.Width) / 2,
                this.Location.Y + (this.Height - formulario.Height) / 2
            );
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
