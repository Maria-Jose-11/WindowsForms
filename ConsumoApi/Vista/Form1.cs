using ConsumoApi.Controlador;
using ConsumoApi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoApi
{
    public partial class Form1 : Form
    {
        private PersonajeControlador personajeControlador;
        private Personajes personajes;
        public Form1()
        {
            InitializeComponent();
            personajeControlador = new PersonajeControlador();
        }

        public async void ObtenerPersonajes()
        {
            personajes = await personajeControlador.GetPersonajesAsync();
            if (personajes != null)
            {
                foreach(var personaje in personajes?.results)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgbPersonajes);
                    row.Cells[0].Value = personaje.name;
                    row.Cells[1].Value = personaje.gender;
                    row.Cells[2].Value = personaje.species;
                    row.Cells[3].Value = personaje.origin.name;

                    dgbPersonajes.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se llogró obtener información",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerPersonajes();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
