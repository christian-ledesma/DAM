using Liga.FormUI.DTOs;
using Liga.FormUI.Forms;
using System.Windows.Forms;

namespace Liga.FormUI
{
    public partial class Inicio : Form
    {
        public UsuarioDto _usuario;

        public Inicio(UsuarioDto usuario)
        {
            _usuario = usuario;

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

        private void buttonMiEquipo_Click(object sender, System.EventArgs e)
        {
            openChildForm(new MiEquipo(_usuario.Id));
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
            openChildForm(new MiPerfil(this, _usuario));
        }

        private void buttonNoticias_Click(object sender, System.EventArgs e)
        {
            openChildForm(new Noticias());
        }

        private void buttonCerrarSesion_Click(object sender, System.EventArgs e)
        {
            this.Close();
            var login = new Login();
            login.Show();
        }
    }
}
