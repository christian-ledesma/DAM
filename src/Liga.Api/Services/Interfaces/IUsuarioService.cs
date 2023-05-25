using Liga.Api.DTOs;
using Liga.Api.Entities;
using System.Threading.Tasks;

namespace Liga.Api.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task RegistrarUsuario(Usuario usuario);
        Task<UsuarioLoginResponse> Login(UsuarioLoginDto loginDto);
        Task ActualizarUsuario(Usuario usuario);
        Task<UsuarioDataDto> Get(string email);
    }
}
