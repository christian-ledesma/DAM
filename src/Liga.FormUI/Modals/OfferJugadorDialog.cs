using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System.Windows.Forms;

namespace Liga.FormUI.Modals
{
    public partial class OfferJugadorDialog : Form
    {
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }

        private readonly OfertaService _ofertaService;
        public OfferJugadorDialog()
        {
            _ofertaService = new OfertaService();
            InitializeComponent();
        }

        private void textBoxOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private async void customButton1_Click(object sender, System.EventArgs e)
        {
            var request = new CrearOfertaDto
            {
                JugadorId = JugadorId,
                EquipoId = EquipoId,
                Valor = int.Parse(textBoxOferta.Text)
            };

            await _ofertaService.CrearOferta(request);

            MessageBox.Show("Oferta enviada!");
            this.Close();
        }
    }
}
