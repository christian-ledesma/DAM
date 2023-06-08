using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class OfertaRepository : IOfertaRepository
    {
        private const string TABLE = "Ofertas";
        private readonly AppSettings _settings;

        public OfertaRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<int> CreateAsync(Oferta entity)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var query = $"INSERT INTO {TABLE} OUTPUT INSERTED.Id VALUES(@OfertaEstadoId, @Valor, @JugadorId, @EquipoId)";
            var result = await connection.ExecuteScalarAsync<int>(query, entity);
            return result;
        }
    }
}
