using Liga.FormUI.DTOs;
using Liga.FormUI.Forms;
using Liga.FormUI.Services;
using System;
using System.Windows.Forms;

namespace Liga.FormUI
{
    public partial class Login : Form
    {
        private readonly UsuarioService _usuarioService;
        public Login()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Inserte email");
                return;
            }

            if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Inserte contraseña");
                return;
            }

            var loginDto = new UsuarioLoginDto
            {
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text
            };

            var response = await _usuarioService.Login(loginDto);
            if (response.Success)
            {
                if (response.Admin)
                {
                    var panel = new PanelAdmin();
                    panel.Show();
                }
                else
                {
                    var usuario = new UsuarioDto
                    {
                        Id = int.Parse(response.Id.ToString()),
                        Password = textBoxPassword.Text,
                        Nombre = response.Nombre,
                        Apellidos = response.Apellidos,
                        Email = response.Email,
                        ImagenBytes = response.ImagenBytes
                    };
                    var inicio = new Inicio(usuario);
                    inicio.Show();
                }
                Hide();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}
