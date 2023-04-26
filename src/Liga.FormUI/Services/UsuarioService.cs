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
        public async Task<BaseResponseDto> Login(UsuarioLoginDto usuarioLoginDto)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var json = JsonConvert.SerializeObject(usuarioLoginDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync("api/Usuarios/login", data);
            string resultContent = await result.Content.ReadAsStringAsync();
            
            var response = JsonConvert.DeserializeObject<BaseResponseDto>(resultContent);
            return response;
        }
    }
}
