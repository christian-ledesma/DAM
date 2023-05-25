using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services.Interfaces
{
    public interface INoticiaService
    {
        Task<IEnumerable<Noticia>> GetLatestNews();
    }
}
