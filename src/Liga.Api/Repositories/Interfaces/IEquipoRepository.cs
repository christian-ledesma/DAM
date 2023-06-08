using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Repositories.Interfaces
{
    public interface IEquipoRepository
    {
        Task<IEnumerable<Equipo>> GetList();
        Task<Equipo> GetByEntrenador(int entrenadorId);
        Task<Equipo> FindAsync(int equipoId);
    }
}
