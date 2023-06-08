using Liga.Api.DTOs;
using Liga.Api.Entities;
using Liga.Api.Enums;
using Liga.Api.Repositories.Interfaces;
using Liga.Api.Services.Interfaces;
using System.Threading.Tasks;

namespace Liga.Api.Services.Implementations
{
    public class OfertaService : IOfertaService
    {
        private readonly IJugadorRepository _jugadorRepository;
        private readonly IOfertaRepository _ofertaRepository;
        private readonly IEquipoOfertaRepository _equipoOfertaRepository;
        private readonly INoticiaRepository _noticiaRepository;
        private readonly IEquipoRepository _equipoRepository;

        public OfertaService(IOfertaRepository ofertaRepository,
            IEquipoOfertaRepository equipoOfertaRepository,
            IJugadorRepository jugadorRepository,
            INoticiaRepository noticiaRepository,
            IEquipoRepository equipoRepository)
        {
            _ofertaRepository = ofertaRepository;
            _equipoOfertaRepository = equipoOfertaRepository;
            _jugadorRepository = jugadorRepository;
            _noticiaRepository = noticiaRepository;
            _equipoRepository = equipoRepository;
        }

        public async Task CrearOferta(CrearOfertaDto crearOfertaDto)
        {
            var jugador = await _jugadorRepository.Find(crearOfertaDto.JugadorId);
            var equipo = await _equipoRepository.FindAsync(crearOfertaDto.EquipoId);
            var oferta = new Oferta
            {
                OfertaEstadoId = (int)OfertaEstados.Pendiente,
                Valor = crearOfertaDto.Valor,
                JugadorId = crearOfertaDto.JugadorId,
                EquipoId = crearOfertaDto.EquipoId
            };

            oferta.Id = await _ofertaRepository.CreateAsync(oferta);

            var equipoOferta = new EquipoOferta
            {
                EquipoOfertanteId = crearOfertaDto.EquipoId,
                EquipoOfertadoId = jugador.EquipoId,
                OfertaId = oferta.Id
            };

            await _equipoOfertaRepository.CreateAsync(equipoOferta);

            var noticia = new Noticia
            {
                Titulo = $"{equipo.Nombre} ha lanzado una oferta!",
                Descripcion = $"{equipo.Nombre} ha enviado una nueva oferta para fichar a {jugador.Nombre} {jugador.Apellidos} por un valor de {crearOfertaDto.Valor}!!!!!"
            };

            await _noticiaRepository.CreateAsync(noticia);
        }
    }
}
