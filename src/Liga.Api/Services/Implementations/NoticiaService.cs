using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Liga.Api.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga.Api.Services.Implementations
{
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public async Task<IEnumerable<Noticia>> GetLatestNews()
        {
            var noticias = await _noticiaRepository.GetListAsync();
            var latestNews = noticias.Take(5).OrderByDescending(x => x.Id);

            return latestNews;
        }
    }
}
