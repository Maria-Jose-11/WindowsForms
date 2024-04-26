using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionesDB
{
    public class ConexionMySQL
    {
        private void ConexionBaseMySQL()
        {
            //Formato cadena de conexion: "server=tu_servidor;port=tu_puerto;database=tu_base_de_datos;uid=tu_usuario;password=tu_contraseña;";
            string connectionString = "tu_cadena_de_conexion";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                
                string sqlQuery = "SELECT * FROM empleados";
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
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
