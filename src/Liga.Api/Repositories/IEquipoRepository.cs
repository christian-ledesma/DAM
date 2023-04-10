using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories
{
    public interface IEquipoRepository
    {
        Task<IEnumerable<Equipo>> GetList();
    }
}
