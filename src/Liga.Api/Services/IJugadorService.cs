using Liga.Api.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services
{
    public interface IJugadorService
    {
        Task<IEnumerable<Jugador>> GetAll();
        Task <IEnumerable<Jugador>> GetAllPlayersById(int teamId);
        Task<int> CreatePlayer(Jugador jugador);
        Task<int> UpdatePlayer(Jugador jugador);
    }
}
