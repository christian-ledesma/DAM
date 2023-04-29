using Liga.FormUI.DTOs;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Liga.FormUI.Services
{
    public class UsuarioService
    {
        public async Task<UsuarioLoginResponse> Login(UsuarioLoginDto usuarioLoginDto)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var json = JsonConvert.SerializeObject(usuarioLoginDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync("api/Usuarios/login", data);
            string resultContent = await result.Content.ReadAsStringAsync();
            
            var response = JsonConvert.DeserializeObject<UsuarioLoginResponse>(resultContent);
            return response;
        }

        public async Task<BaseResponseDto> Update(UsuarioDto usuarioDto)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var json = JsonConvert.SerializeObject(usuarioDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PutAsync("api/Usuarios", data);
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<UsuarioLoginResponse>(resultContent);
            return response;
        }

        public async Task<UsuarioDataDto> GetUserData(string email)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var result = await client.GetAsync($"api/Usuarios/getData/{email}");
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<UsuarioDataDto>(resultContent);
            return response;
        }
    }
}
