using Liga.Api.Entities;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IOfertaRepository
    {
        Task<int> CreateAsync(Oferta entity);
    }
}
