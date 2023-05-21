using Liga.FormUI.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Liga.FormUI.Services
{
    public class JugadorService
    {
        public async Task<IEnumerable<JugadorDto>> GetJugadoresInTeam(int teamId)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var result = await client.GetAsync($"api/Jugador/ByTeam/{teamId}");
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<IEnumerable<JugadorDto>>(resultContent);
            return response;
        }

        public async Task<IEnumerable<JugadorDto>> GetJugadoresList()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var result = await client.GetAsync($"api/Jugador");
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<IEnumerable<JugadorDto>>(resultContent);
            return response;
        }
    }
}
