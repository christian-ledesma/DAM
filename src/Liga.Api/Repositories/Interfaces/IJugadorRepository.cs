using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IJugadorRepository
    {
        Task<IEnumerable<Jugador>> GetPlayers();
        Task<IEnumerable<Jugador>> GetPlayersByTeam(int teamId);
        Task<Jugador> Find(int playerId);
        Task<int> DeletePlayerById(int playerId);
        Task<int> CreatePlayer(Jugador jugador);
        Task<int> UpdatePlayer(Jugador jugador);
    }
}
