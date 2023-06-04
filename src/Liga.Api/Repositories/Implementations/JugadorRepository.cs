using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class JugadorRepository : IJugadorRepository
    {
        private const string TABLE = "Jugadores";
        private readonly AppSettings _settings;

        public JugadorRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<int> DeletePlayerById(int playerId)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.ExecuteAsync($"DELETE FROM {TABLE} WHERE Id = {playerId}");
            return result;
        }

        public async Task<IEnumerable<Jugador>> GetPlayersByTeam(int teamId)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.QueryAsync<Jugador>($"SELECT * FROM {TABLE} WHERE equipoId = {teamId}");
            return result;
        }

        public async Task<int> CreatePlayer(Jugador jugador)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var player = await connection.ExecuteAsync
                ($"INSERT INTO {TABLE} VALUES(@EquipoId, @Nombre, @Valor, @Nacionalidad, @Edad, @Posicion)", jugador);
            return player;
        }

        public async Task<int> UpdatePlayer(Jugador jugador)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var player = await connection.ExecuteAsync
                ($@"UPDATE {TABLE} SET Nombre = @Nombre, Apellidos = @Apellidos,
                                     Nacionalidad = @Nacionalidad, Dorsal = @Dorsal
                                    WHERE Id = @Id", jugador);
            return player;
        }

        public async Task<IEnumerable<Jugador>> GetPlayers()
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var list = await connection.QueryAsync<Jugador>($"SELECT * FROM {TABLE}");
            return list;
        }

        public async Task<Jugador> Find(int playerId)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.QueryFirstAsync<Jugador>($"SELECT * FROM {TABLE} WHERE Id = {playerId}");
            return result;
        }
    }
}
