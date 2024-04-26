using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionesDB
{


    //Para conectar una aplicación Windows Forms a una base de datos SQL Server, puedes seguir estos pasos básicos:

    //Agregar un Controlador de Datos:
    //En tu proyecto de Windows Forms en Visual Studio, puedes agregar un controlador de datos para facilitar la conexión y el acceso a la base de datos SQL Server.Puedes hacerlo desde el menú "Datos" -> "Agregar nuevo origen de datos" y seguir el asistente para establecer la conexión.
    //Establecer la Cadena de Conexión:
    //Asegúrate de tener la cadena de conexión correcta para tu base de datos SQL Server. La cadena de conexión contendrá información como el servidor, la base de datos, el nombre de usuario y la contraseña (si es necesario). Puedes establecer esta cadena de conexión en el código o en la configuración de la aplicación.
    //Abrir la Conexión y Ejecutar Consultas:
    //Una vez que tienes la cadena de conexión configurada, puedes abrir una conexión a la base de datos utilizando la clase SqlConnection. Luego, puedes ejecutar consultas SQL utilizando objetos como SqlCommand y SqlDataReader.
    public class ConexionSQLServer
    {
        private void ConexionBaseSQLServer()
        {

            //FORMATO PARA CADENA DE CONEXIÓN: Data Source=tu_servidor;Initial Catalog=tu_base_de_datos;User ID=tu_usuario;Password=tu_contraseña;

            string connectionString = "tu_cadena_de_conexion";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Ejemplo de consulta
                string sqlQuery = "SELECT * FROM empleados";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string nombre = reader.GetString(1);
                        }
                    }
                }
            }
        }
    }
}
