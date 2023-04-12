using Dapper;
using Liga.Api.Entities;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
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
    }
}
