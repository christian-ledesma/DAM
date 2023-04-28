using Dapper;
using Liga.Api.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private const string TABLE = "Usuarios";
        private readonly AppSettings _settings;

        public UsuarioRepository(AppSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public async Task CreateUser(Usuario usuario)
        {
            var query = $@"INSERT INTO {TABLE}
                                       ([Email]
                                       ,[Password]
                                       ,[Nombre]
                                       ,[Apellidos]
                                       ,[Admin])
                                 VALUES
                                       (@Email,
                                       @Password,
                                       @Nombre,
                                       @Apellidos,
                                       @Admin)";
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            await connection.ExecuteAsync(query, usuario);
        }

        public async Task<Usuario> GetByEmail(string email)
        {
            var query = $"SELECT * FROM {TABLE} WHERE Email = @Email";
            var param = new { Email = email };
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var result = await connection.QueryFirstOrDefaultAsync<Usuario>(query, param);
            return result;
        }

        public async Task UpdateUser(Usuario usuario)
        {
            var query = $@"UPDATE Usuarios
                            SET Email = @Email,
                                Password = @Password,
                                Nombre = @Nombre,
                                Apellidos = @Apellidos
                            WHERE Id = @Id";
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            await connection.ExecuteAsync(query, usuario);
        }
    }
}
