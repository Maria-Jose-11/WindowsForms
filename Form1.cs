using IntroduccionWindowsForms.Datos;
using IntroduccionWindowsForms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroduccionWindowsForms
{
    public partial class Form1 : Form
    {
        DataTable tablaUsuarios;
        Usuario informacion = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Añadir la información ingresada por el usuario al modelo
            ModeloUsuario modeloUsuario = new ModeloUsuario()
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            informacion.Guardar(modeloUsuario);

            //Mostrar datos de la tabla en el orden ingresado
            Iniciar();

            //Limpiar campos
            LimpiarCampos();

            //Crear las filas de la tabla para mostrar la información
            foreach (var info in informacion.Consultar())
            {
                DataRow fila = tablaUsuarios.NewRow();
                fila["Nombre"] = info.Nombre;
                fila["Cedula"] = info.Cedula;
                fila["Edad"] = info.Edad;
                tablaUsuarios.Rows.Add(fila);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void Iniciar()
        {
            tablaUsuarios = new DataTable();
            tablaUsuarios.Columns.Add("Nombre");
            tablaUsuarios.Columns.Add("Cedula");
            tablaUsuarios.Columns.Add("Edad");
            GridView.DataSource = tablaUsuarios;
        }

        //Método para limppiar los campos
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtEdad.Text = string.Empty;
        }

    }
}
