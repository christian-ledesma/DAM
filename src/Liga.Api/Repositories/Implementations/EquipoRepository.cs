﻿using Dapper;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Implementations
{
    public class EquipoRepository : IEquipoRepository
    {
        private const string TABLE = "Equipos";
        private readonly AppSettings _settings;

        public EquipoRepository(AppSettings settings)
        {
            _settings = settings;
        }

        public async Task<Equipo> FindAsync(int equipoId)
        {
            using var connection = new SqlConnection(_settings.EducationServer);
            connection.Open();

            var query = $"SELECT * FROM {TABLE} WHERE Id = {equipoId}";
            var result = await connection.QueryFirstOrDefaultAsync<Equipo>(query);
            return result;
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
