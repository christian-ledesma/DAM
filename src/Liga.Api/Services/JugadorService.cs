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

        public async Task<int> UpdatePlayer(Jugador jugador)
        {
            var player = await _jugadorRepository.UpdatePlayer(jugador);
            return player;
        }


        public async Task<int> DeletePlayer(int playerId)
        {
            var player = await _jugadorRepository.DeletePlayerById(playerId);
            return player;
        }

        public async Task<IEnumerable<Jugador>> GetAllPlayersById(int teamId)
        {
            var jugadores = await _jugadorRepository.GetPlayersByTeam(teamId);
            return jugadores;
        }

        public async Task<IEnumerable<Jugador>> GetAll()
        {
            var list = await _jugadorRepository.GetPlayers();
            return list;
        }
    }
}
