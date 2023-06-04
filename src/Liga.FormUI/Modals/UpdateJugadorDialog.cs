using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System.Windows.Forms;

namespace Liga.FormUI.Modals
{
    public partial class UpdateJugadorDialog : Form
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public int Dorsal { get; set; }

        private readonly JugadorService _jugadorService;
        public UpdateJugadorDialog()
        {
            _jugadorService = new JugadorService();
            InitializeComponent();
        }

        private async void customButtonGuardar_Click(object sender, System.EventArgs e)
        {
            var dto = new JugadorUpdateDto
            {
                Id = Id,
                Nombre = textBoxNombre.Text,
                Apellidos = textBoxApellidos.Text,
                Nacionalidad = textBoxNacionalidad.Text,
                Dorsal = int.Parse(textBoxDorsal.Text)
            };
            await _jugadorService.UpdateJugador(dto);

            this.Close();
        }

        private void textBoxDorsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void UpdateJugadorDialog_Load(object sender, System.EventArgs e)
        {
            textBoxNombre.Text = Nombre;
            textBoxApellidos.Text = Apellido;
            textBoxNacionalidad.Text = Nacionalidad;
            textBoxDorsal.Text = Dorsal.ToString();
        }
    }
}
