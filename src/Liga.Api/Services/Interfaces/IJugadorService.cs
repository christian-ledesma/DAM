using Liga.Api.DTOs;
using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services.Interfaces
{
    public interface IJugadorService
    {
        Task<IEnumerable<JugadorDto>> GetAll();
        Task<IEnumerable<JugadorDto>> GetPlayersInTeam(int teamId);
        Task<int> DeletePlayer(int playerId);
        Task<int> CreatePlayer(Jugador jugador);
        Task<int> UpdatePlayer(JugadorUpdateDto jugador);
    }
}
