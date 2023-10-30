using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class ComisionServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Comision";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Comision> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var comision = JsonConvert.DeserializeObject<Comision>(responseContent);
                return comision;
            }
            else return null;
        }
        public static async Task<List<Comision>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var comisiones = JsonConvert.DeserializeObject<List<Comision>>(content);
                return comisiones;
            }
            else return null;
        }
        public static async Task<Comision> Create(Comision Comision)
        {
            var ComisionJson = JsonConvert.SerializeObject(Comision);
            var content = new StringContent(ComisionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedComision = JsonConvert.DeserializeObject<Comision>(responseContent);
                return addedComision;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Comision comision)
        {
            var comisionJson = JsonConvert.SerializeObject(comision);
            var content = new StringContent(comisionJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{comision.idComision}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

