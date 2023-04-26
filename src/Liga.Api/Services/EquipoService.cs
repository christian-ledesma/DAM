using Liga.Api.Entities;
using Liga.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liga.Api.Services
{
    public class EquipoService : IEquipoService
    {
        private readonly IEquipoRepository _equipoRepository;

        public EquipoService(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public async Task<IEnumerable<Equipo>> GetAll()
        {
            var equipos = await _equipoRepository.GetList();
            return equipos;
        }

        public async Task<Equipo> GetByEntrenador(int entrenadorId)
        {
            var equipo = await _equipoRepository.GetByEntrenador(entrenadorId);
            return equipo;
        }
    }
}
