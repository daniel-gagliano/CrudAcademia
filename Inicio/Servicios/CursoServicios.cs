using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class CursoServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Curso";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Curso> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<Curso>(responseContent);
                return curso;
            }
            else return null;
        }
        public static async Task<List<Curso>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<Curso>>(content);
                return cursos;
            }
            else return null;
        }
        public static async Task<Curso> Create(Curso Curso)
        {
            var CursoJson = JsonConvert.SerializeObject(Curso);
            var content = new StringContent(CursoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedCurso = JsonConvert.DeserializeObject<Curso>(responseContent);
                return addedCurso;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Curso curso)
        {
            var cursoJson = JsonConvert.SerializeObject(curso);
            var content = new StringContent(cursoJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{curso.idCurso}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

