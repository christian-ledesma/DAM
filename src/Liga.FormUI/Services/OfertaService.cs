using Liga.FormUI.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Liga.FormUI.Services
{
    public class OfertaService
    {
        public async Task CrearOferta(CrearOfertaDto dto)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.API_URL);

            var json = JsonConvert.SerializeObject(dto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            await client.PostAsync("api/Ofertas", data);
        }
    }
}
