using Liga.Api.DTOs;
using Liga.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Liga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertasController : ControllerBase
    {
        private readonly IOfertaService _ofertaService;

        public OfertasController(IOfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffer([FromBody] CrearOfertaDto crearOfertaDto)
        {
            await _ofertaService.CrearOferta(crearOfertaDto);
            return Ok();
        }
    }
}
