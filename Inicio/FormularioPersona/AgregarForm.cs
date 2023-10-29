using BibliotecaClases;
using CrudAcademia.Context;
using Inicio.Servicios;
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

namespace Inicio.FormularioPersona
{
    public partial class AgregarForm : Form
    {
        private PersonaServicios personaServicios;
        private UsuarioServicios usuarioServicios;
        public Persona NuevaPersona { get; private set; }
        public Usuario NuevoUsuario { get; private set; }

        private AcademiaContext context;
        private DbContextOptionsBuilder<AcademiaContext> optionsBuilder;


        public AgregarForm(int ultimoId, PersonaServicios personaServicios, UsuarioServicios usuarioServicios)
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
            CargarPlanes();

            this.personaServicios = personaServicios;
            this.usuarioServicios = usuarioServicios;
        }
        private void CargarPlanes()
        {

            // Obtiene las especialidades de la base de datos
            var planes = context.Plan.ToList();

            // Enlaza la lista de especialidades al ComboBox
            txtIdPlan.DataSource = planes;
            txtIdPlan.DisplayMember = "descPlan"; // Establece la propiedad que se mostrará en el ComboBox
            txtIdPlan.ValueMember = "idPLan"; // Establece la propiedad que se utilizará como valor seleccionado
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIdPlan.Text) || string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtTipoPersona.Text)||
                string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))


            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {
                if (int.TryParse(txtLegajo.Text, out int legajoOk))
                {
                    //Persona
                    int ultimoID = Convert.ToInt32(txtID.Text);
                    String apellido = txtApellido.Text;
                    String direccion = txtDireccion.Text;
                    String nombre = txtNombre.Text;
                    String email = txtEmail.Text;
                    DateTime fechaNacimiento = DateTime.Now;
                    int IdPlan = (int)txtIdPlan.SelectedValue;
                    int legajo = Convert.ToInt32(txtLegajo.Text);
                    String telefono = txtTelefono.Text;
                    String tipoPersona = txtTipoPersona.Text;
                    //Usuario
                    String usuario = txtUsuario.Text;
                    String contraseña = txtContraseña.Text;


                    //Crear nueva persona
                    Persona nuevaPersona = new Persona()
                    {

                        apellido = apellido,
                        nombre = nombre,
                        direccion = direccion,
                        email = email,
                        fechaNacimiento = fechaNacimiento,
                        IdPlan = IdPlan,
                        legajo = legajo,
                        telefono = telefono,
                        tipoPersona = tipoPersona,
                    };
                    await personaServicios.AgregarPersonaAsync(nuevaPersona);
                    //Crear nuevo Usuario
                    Usuario nuevoUsuario = new Usuario()
                    {
                        userName = usuario,
                        password = contraseña,
                        idPersona = ultimoID,
                    };
                    await usuarioServicios.AgregarUsuarioAsync(nuevoUsuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El campo 'Legajo' debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
