using Liga.Api.Entities;
using Liga.Api.Repositories;
using Liga.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections;
using System.Threading.Tasks;

namespace Liga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        private readonly IJugadorService _jugadorService;
        public JugadorController(IJugadorService jugadorService)
        {
            _jugadorService = jugadorService;
        }

        [HttpGet]
        //[Route("{id}")]
        public async Task<IActionResult> GetById([FromQuery] int teamId)
        {
            var jugadores = await _jugadorService.GetAllPlayersById(teamId);
            return Ok(jugadores);
        }
    }
}
