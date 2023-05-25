using Liga.Api.Entities;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task CreateUser(Usuario usuario);
        Task<Usuario> GetByEmail(string email);
        Task UpdateUser(Usuario usuario);
    }
}
