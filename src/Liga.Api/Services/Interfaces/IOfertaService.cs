using Liga.Api.DTOs;
using System.Threading.Tasks;

namespace Liga.Api.Services.Interfaces
{
    public interface IOfertaService
    {
        Task CrearOferta(CrearOfertaDto crearOfertaDto);
    }
}
