using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionWindowsForms.Modelo
{
    //CLASE DE TIPO PÚBLICA PARA QUE PUEDA SER LLAMADA DESDE CUALQUIER PARTE DEL CÓDIGO
    public class ModeloUsuario
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
    }
}
