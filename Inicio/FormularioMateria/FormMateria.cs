using BibliotecaClases;
using CrudAcademia.Context;
using FormularioEspecialidad.Models;
using Inicio.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.FormularioMateria
{
    public partial class FormMateria : Form
    {
        private List<Materia> MateriaList = new List<Materia>();
        public FormMateria()
        {
            InitializeComponent();
            this.List();

        }

        private async void List()
        {
            var materias = await MateriaServicios.Get();
            dgvPersonas.DataSource = materias;
        }

        protected async Task<int> ObtenerUltimoId()
        {
            if (MateriaList.Any())
            {
                // Ordena la lista de personas por ID de manera descendente y toma el primer elemento
                Materia ultimaPersona = (await MateriaServicios.Get()).OrderByDescending(m => m.idMateria).First();
                return ultimaPersona.idMateria;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor inicial
                return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
