using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class NoticiaRepository : INoticiaRepository
    {
        private const string TABLE = "Noticias";
        private readonly AppSettings _settings;

        public NoticiaRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<IEnumerable<Noticia>> GetListAsync()
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var query = $"SELECT * FROM {TABLE}";
            var result = await connection.QueryAsync<Noticia>(query);
            return result;
        }
    }
}
