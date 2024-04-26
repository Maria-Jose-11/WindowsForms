using IntroduccionWindowsForms.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroduccionWindowsForms.Datos
{
    public class Usuario
    {
        List<ModeloUsuario> lista = new List<ModeloUsuario>();

        /// <summary>
        /// Guardar información del usuario
        /// </summary>
        /// <param name="modeloUsuario"></param>
        public void Guardar(ModeloUsuario modeloUsuario)
        {
            lista.Add(modeloUsuario);
        }


        /// <summary>
        /// Consulta los usuarios registrados en la lista
        /// </summary>
        /// <returns>lista de usuarios</returns>
        public List<ModeloUsuario> Consultar()
        {
            return lista;
        }


    }
}
