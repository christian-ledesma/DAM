using Liga.Api.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public interface IJugadorRepository
    {
        Task<IEnumerable<Jugador>> GetPlayersByTeam(int teamId);
    }
}
