using Liga.FormUI.DTOs;
using Liga.FormUI.Forms;
using System.Windows.Forms;

namespace Liga.FormUI
{
    public partial class Inicio : Form
    {
        public UsuarioDto _usuario;
        private int activeTab = 0;

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
            if (activeTab != 1)
                openChildForm(new MiEquipo(_usuario.Id));
            activeTab = 1;
        }

        private void buttonEquipos_Click(object sender, System.EventArgs e)
        {
            if (activeTab != 2)
                openChildForm(new Equipos());
            activeTab = 2;
        }

        private void ButtonInicio_Click(object sender, System.EventArgs e)
        {
            if (activeForm != null && activeTab != 0)
                activeForm.Close();
            activeTab = 0;
        }

        private void buttonJugadores_Click(object sender, System.EventArgs e)
        {
            if (activeTab != 3)
                openChildForm(new Jugadores());
            activeTab = 3;
        }

        private void buttonEstadísticas_Click(object sender, System.EventArgs e)
        {
            if (activeTab != 4)
                openChildForm(new Clasificacion());
            activeTab = 4;
        }

        private void buttonPerfil_Click(object sender, System.EventArgs e)
        {
            if (activeTab != 5)
                openChildForm(new MiPerfil(this, _usuario));
            activeTab = 5;
        }

        private void buttonNoticias_Click(object sender, System.EventArgs e)
        {
            if (activeTab != 6)
                openChildForm(new Noticias());
            activeTab = 6;
        }

        private void buttonCerrarSesion_Click(object sender, System.EventArgs e)
        {
            this.Close();
            var login = new Login();
            login.Show();
        }
    }
}
