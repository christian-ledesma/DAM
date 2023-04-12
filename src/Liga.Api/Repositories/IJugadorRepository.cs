﻿using Liga.Api.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public interface IJugadorRepository
    {
        Task<IEnumerable<Jugador>> GetPlayers();
        Task<IEnumerable<Jugador>> GetPlayersByTeam(int teamId);
        Task<int> CreatePlayer(Jugador jugador);
        Task<int> UpdatePlayer(Jugador jugador);
    }
}
