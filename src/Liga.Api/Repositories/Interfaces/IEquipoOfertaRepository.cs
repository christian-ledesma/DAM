using Liga.Api.Entities;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IEquipoOfertaRepository
    {
        Task CreateAsync(EquipoOferta entity);
    }
}
