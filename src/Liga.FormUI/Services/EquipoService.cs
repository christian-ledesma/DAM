using Liga.FormUI.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Liga.FormUI.Services
{
    public class EquipoService
    {
        public async Task<EquipoDto> GetByEntrenador(int entrenadorId)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var result = await client.GetAsync($"api/Equipo/ByEntrenador/{entrenadorId}");
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<EquipoDto>(resultContent);
            return response;
        }
    }
}
