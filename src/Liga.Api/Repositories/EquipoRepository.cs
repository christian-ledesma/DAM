﻿using Dapper;
using Liga.Api.Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public class EquipoRepository
    {
        private const string TABLE = "";
        private readonly AppSettings _settings;

        public EquipoRepository(AppSettings settings)
        {
            _settings = settings;
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
