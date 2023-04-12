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
        protected ResponseBase _response;
        private readonly IJugadorService _jugadorService;
        public JugadorController(IJugadorService jugadorService)
        {
            _jugadorService = jugadorService;
            this._response = new ResponseBase();
        }

        [HttpGet]
        //[Route("{id}")]
        public async Task<IActionResult> GetById([FromQuery] int teamId)
        {
            var jugadores = await _jugadorService.GetAllPlayersById(teamId);
            return Ok(jugadores);
        }

        [HttpPost]
        public async Task<object> Post([FromBody] Jugador jugador)
        {
            try
            {
                await _jugadorService.CreatePlayer(jugador);
            }
            catch(Exception e)
            {
                _response.Success = false;
                _response.Message = e.Message;
            }
            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] Jugador jugador)
        {
            try
            {
                await _jugadorService.UpdatePlayer(jugador);
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
