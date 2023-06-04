using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IPosicionRepository
    {
        Task<IEnumerable<Posicion>> FindAllAsync();
    }
}
