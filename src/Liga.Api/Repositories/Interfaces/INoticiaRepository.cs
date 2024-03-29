﻿using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface INoticiaRepository
    {
        Task CreateAsync(Noticia entity);
        Task<IEnumerable<Noticia>> GetListAsync();
    }
}
