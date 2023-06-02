using Liga.FormUI.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Liga.FormUI.Services
{
    public class NoticiaService
    {
        public async Task<IEnumerable<NoticiaDto>> GetUltimasNoticias()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var result = await client.GetAsync($"api/Noticias");
            string resultContent = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<IEnumerable<NoticiaDto>>(resultContent);
            return response;
        }
    }
}
