using BibliotecaClases;
using CrudAcademia.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.FormularioPlan
{
    public partial class AgregarForm : Form
    {
        public Plan NuevoPlan { get; private set; }
        private DbContextOptionsBuilder<AcademiaContext> optionsBuilder;
        private AcademiaContext context;
        public AgregarForm(int ultimoId)
        {
            InitializeComponent();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("dbAcademia");

            optionsBuilder = new DbContextOptionsBuilder<AcademiaContext>();
            optionsBuilder.UseSqlServer(connectionString);




            txtID.Text = (ultimoId).ToString();
            context = new AcademiaContext(optionsBuilder.Options);
            CargarEspecialidad();
        }

        private void CargarEspecialidad()
        {
            var especialidades = context.Especialidad.ToList();
            txtEspecialidad.DataSource = especialidades;
            txtEspecialidad.DisplayMember = "descEspecialidad"; // Establece la propiedad que se mostrará en el ComboBox
            txtEspecialidad.ValueMember = "idEspecialidad"; // Establece la propiedad que se utilizará como valor seleccionado
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {
                int ultimoID = Convert.ToInt32(txtID.Text);
                String descripcion = txtDescripcion.Text;
                int IdEspecialidad = (int)txtEspecialidad.SelectedValue;

                //Crear nueva persona
                Plan nuevoPlan = new Plan()
                {

                    descPlan = descripcion,
                    idEspecialidad = IdEspecialidad,
                };
                NuevoPlan = nuevoPlan;
                this.Close();


            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
