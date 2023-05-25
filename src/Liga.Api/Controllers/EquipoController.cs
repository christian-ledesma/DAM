using Liga.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Liga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoService _equipoService;

        public EquipoController(IEquipoService equipoService)
        {
            _equipoService = equipoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            var equipos = await _equipoService.GetAll();
            return Ok(equipos);
        }

        [HttpGet]
        [Route("ByEntrenador/{entrenadorId}")]
        public async Task<IActionResult> GetByEntrenador(int entrenadorId)
        {
            var equipos = await _equipoService.GetByEntrenador(entrenadorId);
            return Ok(equipos);
        }
    }
}
