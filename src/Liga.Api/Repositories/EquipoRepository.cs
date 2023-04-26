using Dapper;
using Liga.Api.Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private const string TABLE = "Equipos";
        private readonly AppSettings _settings;

        public EquipoRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<Equipo> GetByEntrenador(int entrenadorId)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.QueryFirstOrDefaultAsync<Equipo>($"SELECT * FROM {TABLE} WHERE EntrenadorId = {entrenadorId}");
            return result;
        }

        public async Task<IEnumerable<Equipo>> GetList()
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.QueryAsync<Equipo>($"SELECT * FROM {TABLE}");
            return result;
        }
    }
}
