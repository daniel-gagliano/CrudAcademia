using BibliotecaClases;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Inicio.Servicios
{
    public static class UsuarioServicios
    {
        private static readonly string baseUrl = "https://localhost:7077/api/Usuario";
        private static HttpClient httpClient = new HttpClient();
        public static async Task<Usuario> GetOne(int id)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var usuario = JsonConvert.DeserializeObject<Usuario>(responseContent);
                return usuario;
            }
            else return null;
        }
        public static async Task<List<Usuario>> Get()
        {
            var response = await httpClient.GetAsync($"{baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);
                return usuarios;
            }
            else return null;
        }
        public static async Task<Usuario> Create(Usuario usuario)
        {
            var usuarioJson = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var addedUsuario = JsonConvert.DeserializeObject<Usuario>(responseContent);
                return addedUsuario;
            }
            else return null;
        }
        public static async Task<Boolean> Update(Usuario usuario)
        {
            var usuarioJson = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(usuarioJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{baseUrl}/{usuario.idUsuario}", content);
            return response.IsSuccessStatusCode;
        }
        public static async Task<Boolean> Delete(int id)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }

        public static async Task<Usuario> Login(Credenciales credenciales)
        {
            var credencialesJson = JsonConvert.SerializeObject(credenciales);
            var content = new StringContent(credencialesJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{baseUrl}/autenticar", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var usuario = JsonConvert.DeserializeObject<Usuario>(responseContent);
                return usuario;
            }
            else return null;
        }
    }
}