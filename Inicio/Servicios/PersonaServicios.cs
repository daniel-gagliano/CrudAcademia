using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class PersonaServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Persona";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Persona> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var persona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return persona;
            }
            else return null;
        }
        public static async Task<List<Persona>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var personas = JsonConvert.DeserializeObject<List<Persona>>(content);
                return personas;
            }
            else return null;
        }
        public static async Task<Persona> Create(Persona persona)
        {
            var personaJson = JsonConvert.SerializeObject(persona);
            var content = new StringContent(personaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedpersona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return addedpersona;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Persona persona)
        {
            var personaJson = JsonConvert.SerializeObject(persona);
            var content = new StringContent(personaJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{persona.legajo}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int legajo)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{legajo}");
            return response.IsSuccessStatusCode;
        }

        public static async Task<Persona> Login(Credenciales credenciales)
        {
            var credencialesJson = JsonConvert.SerializeObject(credenciales);
            var content = new StringContent(credencialesJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}/autenticar", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var persona = JsonConvert.DeserializeObject<Persona>(responseContent);
                return persona;
            }
            else return null;
        }

        public static async Task<bool> UsuarioDisponible(string nombreUsuario)
        {
            var content = new StringContent(nombreUsuario, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}/autenticar", content);
            return (response.IsSuccessStatusCode);
        }
    }
}

