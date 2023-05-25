using Liga.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services.Interfaces
{
    public interface IEquipoService
    {
        Task<IEnumerable<Equipo>> GetAll();
        Task<Equipo> GetByEntrenador(int entrenadorId);
    }
}
