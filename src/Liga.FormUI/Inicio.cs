using Liga.FormUI.Forms;
using Liga.FormUI.Services;
using System.Windows.Forms;

namespace Liga.FormUI
{
    public partial class Inicio : Form
    {
        private readonly int _userId;
        private readonly JugadorService _jugadorService;
        private readonly EquipoService _equipoService;

        public Inicio(int userId)
        {
            _userId = userId;
            _jugadorService = new JugadorService();
            _equipoService = new EquipoService();

            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private async void buttonMiEquipo_Click(object sender, System.EventArgs e)
        {
            var equipo = await _equipoService.GetByEntrenador(_userId);
            var jugadores = await _jugadorService.GetJugadoresInTeam(equipo.Id);
            openChildForm(new MiEquipo(equipo, jugadores));
        }

        private void buttonEquipos_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Equipos());
        }

        private void ButtonInicio_Click(object sender, System.EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void buttonJugadores_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Jugadores());
        }

        private void buttonEstadísticas_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Clasificacion());
        }

        private void buttonPerfil_Click(object sender, System.EventArgs e)
        {
            openChildForm(new MiPerfil());
        }

        private void buttonNoticias_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Noticias());
        }
    }
}
