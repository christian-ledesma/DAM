using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class EquipoOfertaRepository : IEquipoOfertaRepository
    {
        private const string TABLE = "EquipoOfertas";
        private readonly AppSettings _settings;

        public EquipoOfertaRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task CreateAsync(EquipoOferta entity)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var query = $"INSERT INTO {TABLE} VALUES(@EquipoOfertanteId, @EquipoOfertadoId, @OfertaId)";
            await connection.ExecuteAsync(query, entity);
        }
    }
}
