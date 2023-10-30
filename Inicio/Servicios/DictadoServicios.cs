using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class DictadoServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Dictado";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Dictado> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var dictado = JsonConvert.DeserializeObject<Dictado>(responseContent);
                return dictado;
            }
            else return null;
        }
        public static async Task<List<Dictado>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var dictados = JsonConvert.DeserializeObject<List<Dictado>>(content);
                return dictados;
            }
            else return null;
        }
        public static async Task<Dictado> Create(Dictado Dictado)
        {
            var DictadoJson = JsonConvert.SerializeObject(Dictado);
            var content = new StringContent(DictadoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedDictado = JsonConvert.DeserializeObject<Dictado>(responseContent);
                return addedDictado;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Dictado dictado)
        {
            var dictadoJson = JsonConvert.SerializeObject(dictado);
            var content = new StringContent(dictadoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{dictado.idDictado}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

