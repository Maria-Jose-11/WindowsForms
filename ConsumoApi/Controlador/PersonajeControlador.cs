using ConsumoApi.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi.Controlador
{
    public class PersonajeControlador
    {
        private HttpClient cliente;

        public PersonajeControlador()
        {
            cliente = new HttpClient();
        }

        public async Task<Personajes> GetPersonajesAsync()
        {
            try
            {
                Personajes personajes = new Personajes();
                HttpResponseMessage respuesta = await cliente.GetAsync("https://rickandmortyapi.com/api/character");

                respuesta.EnsureSuccessStatusCode();
                string respuestaJson = await respuesta.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Personajes>(respuestaJson);

                return personajes;
            }
            catch(Exception e)
            {
                return null;
            }

            
        }
    }
}
