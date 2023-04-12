using Liga.Api.Entities;
using Liga.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services
{
    public class JugadorService : IJugadorService
    {
        private readonly IJugadorRepository _jugadorRepository;

        public JugadorService(IJugadorRepository jugadorRepository)
        {
            _jugadorRepository = jugadorRepository;
        }

        public async Task<int> CreatePlayer(Jugador jugador)
        {
            var player = await _jugadorRepository.CreatePlayer(jugador);
            return player;
        }

        public async Task<IEnumerable<Jugador>> GetAllPlayersById(int teamId)
        {
            var jugadores = await _jugadorRepository.GetPlayersByTeam(teamId);
            return jugadores;
        }
    }
}
