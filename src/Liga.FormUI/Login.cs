using Liga.FormUI.DTOs;
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
                int userId = int.Parse(response.Content.ToString());
                var inicio = new Inicio(userId);
                Hide();
                inicio.Show();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}
