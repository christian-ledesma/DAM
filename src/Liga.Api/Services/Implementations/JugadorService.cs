using Liga.Api.DTOs;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Liga.Api.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga.Api.Services.Implementations
{
    public class JugadorService : IJugadorService
    {
        private readonly IJugadorRepository _jugadorRepository;
        private readonly IPosicionRepository _posicionRepository;

        public JugadorService(IJugadorRepository jugadorRepository, IPosicionRepository posicionRepository)
        {
            _jugadorRepository = jugadorRepository;
            _posicionRepository = posicionRepository;
        }

        public async Task<int> CreatePlayer(Jugador jugador)
        {
            var player = await _jugadorRepository.CreatePlayer(jugador);
            return player;
        }

        public async Task<int> UpdatePlayer(JugadorUpdateDto jugador)
        {
            var player = await _jugadorRepository.Find(jugador.Id);

            player.Nombre = jugador.Nombre;
            player.Apellidos = jugador.Apellidos;
            player.Nacionalidad = jugador.Nacionalidad;
            player.Dorsal = jugador.Dorsal;

            var result = await _jugadorRepository.UpdatePlayer(player);
            return result;
        }

        public async Task<int> DeletePlayer(int playerId)
        {
            var player = await _jugadorRepository.DeletePlayerById(playerId);
            return player;
        }

        public async Task<IEnumerable<JugadorDto>> GetPlayersInTeam(int teamId)
        {
            var jugadores = await _jugadorRepository.GetPlayersByTeam(teamId);
            var posiciones = await _posicionRepository.FindAllAsync();

            var result = jugadores.Select(x => new JugadorDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellidos = x.Apellidos,
                Dorsal = x.Dorsal,
                Nacionalidad = x.Nacionalidad,
                Edad = x.Edad,
                Posicion = posiciones.Where(y => y.Id == x.PosicionId).First().Nombre,
                Valor = x.Valor,
            });
            return result;
        }

        public async Task<IEnumerable<JugadorDto>> GetAll()
        {
            var jugadores = await _jugadorRepository.GetPlayers();
            var posiciones = await _posicionRepository.FindAllAsync();

            var result = jugadores.Select(x => new JugadorDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellidos = x.Apellidos,
                Dorsal = x.Dorsal,
                Nacionalidad = x.Nacionalidad,
                Edad = x.Edad,
                Posicion = posiciones.Where(y => y.Id == x.PosicionId).First().Nombre,
                Valor = x.Valor,
            });
            return result;
        }
    }
}
