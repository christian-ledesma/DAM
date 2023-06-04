using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class PosicionRepository : IPosicionRepository
    {
        private const string TABLE = "Posiciones";
        private readonly AppSettings _settings;

        public PosicionRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<IEnumerable<Posicion>> FindAllAsync()
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var query = $"SELECT * FROM {TABLE}";
            var result = await connection.QueryAsync<Posicion>(query);
            return result;
        }
    }
}
