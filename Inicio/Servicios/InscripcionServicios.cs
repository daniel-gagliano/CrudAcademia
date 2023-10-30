using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class InscripcionServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Inscripcion";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Inscripcion> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var inscripcion = JsonConvert.DeserializeObject<Inscripcion>(responseContent);
                return inscripcion;
            }
            else return null;
        }
        public static async Task<List<Inscripcion>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var inscripciones = JsonConvert.DeserializeObject<List<Inscripcion>>(content);
                return inscripciones;
            }
            else return null;
        }
        public static async Task<Inscripcion> Create(Inscripcion Inscripcion)
        {
            var InscripcionJson = JsonConvert.SerializeObject(Inscripcion);
            var content = new StringContent(InscripcionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedInscripcion = JsonConvert.DeserializeObject<Inscripcion>(responseContent);
                return addedInscripcion;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Inscripcion inscripcion)
        {
            var inscripcionJson = JsonConvert.SerializeObject(inscripcion);
            var content = new StringContent(inscripcionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{inscripcion.idInscripcion}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}