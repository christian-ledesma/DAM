using Liga.Api.DTOs;
using Liga.Api.Entities;
using Liga.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Liga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        protected ResponseBase _response;
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
            _response = new ResponseBase();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] Usuario usuario)
        {
            try
            {
                await _usuarioService.RegistrarUsuario(usuario);
                _response.Success = true;
            }
            catch (Exception e)
            {
                _response.Success = false;
                _response.Message = e.Message;
            }
            return Ok(_response);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UsuarioLoginDto loginDto)
        {
            try
            {
                var result = await _usuarioService.Login(loginDto);
                _response.Success = result.Success;
                _response.Content = result.Content;
            }
            catch (Exception e)
            {
                _response.Success = false;
                _response.Message = e.Message;
            }
            return Ok(_response);
        }
    }
}
