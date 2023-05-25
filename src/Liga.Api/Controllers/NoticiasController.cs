using Liga.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Liga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        private readonly INoticiaService _noticiaService;

        public NoticiasController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await _noticiaService.GetLatestNews();
            return Ok(result);
        }
    }
}
