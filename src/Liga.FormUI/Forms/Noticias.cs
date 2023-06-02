using Liga.FormUI.CustomControls;
using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class Noticias : Form
    {
        private IEnumerable<NoticiaDto> _noticias;
        private readonly NoticiaService _noticiaService;
        public Noticias()
        {
            _noticiaService = new NoticiaService();
            InitializeComponent();
        }

        private async void Noticias_Load(object sender, System.EventArgs e)
        {
            _noticias = await _noticiaService.GetUltimasNoticias();

            FillGrid();
        }

        private void FillGrid()
        {
            var noticiaItem = new Noticia[_noticias.Count()];
            for (int i = 0; i < _noticias.Count(); i++)
            {
                noticiaItem[i] = new Noticia
                {
                    Titulo = _noticias.ToArray()[i].Titulo,
                    Descripcion = _noticias.ToArray()[i].Descripcion,
                };
            }

            flowLayoutPanel1.Controls.AddRange(noticiaItem);
        }
    }
}
