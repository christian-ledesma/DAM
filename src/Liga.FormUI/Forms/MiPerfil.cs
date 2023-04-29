using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class MiPerfil : Form
    {
        private readonly UsuarioDto _perfil;
        private readonly UsuarioService _usuarioService;
        private readonly Inicio _mainForm;

        public MiPerfil(Form mainForm,UsuarioDto usuario)
        {
            _perfil = usuario;
            _usuarioService = new UsuarioService();
            _mainForm = mainForm as Inicio;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagePath;
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileDialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar imagen");
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = true;
            textBoxApellidos.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPassword.Enabled = true;
            buttonSubir.Enabled = true;
            buttonCancelar.Visible = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxPassword.Enabled = false;
            buttonSubir.Enabled = false;
            buttonCancelar.Visible = false;
            buttonEditar.Visible = true;
            buttonGuardar.Enabled = false;

            if (textBoxNombre.Text != _perfil.Nombre)
                textBoxNombre.Text = _perfil.Nombre;
            if (textBoxApellidos.Text != _perfil.Apellidos)
                textBoxApellidos.Text = _perfil.Apellidos;
            if (textBoxEmail.Text != _perfil.Email)
                textBoxEmail.Text = _perfil.Email;
            if (pictureBox1.ImageLocation != null)
                pictureBox1.ImageLocation = null;
            if (textBoxPassword.Text != _perfil.Password)
                textBoxPassword.Text = _perfil.Password;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            //TODO: IMPLEMENT IMAGE SAVE
            //FileInfo file = new FileInfo(pictureBox1.ImageLocation);
            //MemoryStream ms = new MemoryStream();

            ////GUARDO SEGÚN EL FORMATO DE LA IMAGEN, SOLO SE ACEPTA JPG o PNG
            //if (file.Extension == ".png")
            //    pictureBox1.Image.Save(ms, ImageFormat.Png);
            //else if (file.Extension == ".jpg")
            //    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

            //byte[] imgData = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(imgData, 0, imgData.Length);

            var password = !string.IsNullOrWhiteSpace(textBoxPassword.Text) ? textBoxPassword.Text : null;

            var usuarioDto = new UsuarioDto
            {
                Id = _perfil.Id,
                Nombre = textBoxNombre.Text,
                Email = textBoxEmail.Text,
                Apellidos = textBoxApellidos.Text,
                Password = password,
                //ImagenBytes = imgData
            };

            var response = await _usuarioService.Update(usuarioDto);
            if (response.Success)
                MessageBox.Show("Actualizado correctamente");
            else
                MessageBox.Show(response.Message);

            textBoxNombre.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxPassword.Enabled = false;
            buttonSubir.Enabled = false;
            buttonCancelar.Visible = false;
            buttonEditar.Visible = true;
            buttonGuardar.Enabled = false;

            var usuarioActualizado = await _usuarioService.GetUserData(_perfil.Email);
            _mainForm._usuario.Nombre = usuarioActualizado.Nombre;
            _mainForm._usuario.Apellidos = usuarioActualizado.Apellidos;
            _mainForm._usuario.Email = usuarioActualizado.Email;
            _mainForm._usuario.ImagenBytes = usuarioActualizado.ImagenBytes;
        }

        private void MiPerfil_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = _perfil.Email;
            textBoxNombre.Text = _perfil.Nombre;
            textBoxApellidos.Text = _perfil.Apellidos;
            textBoxPassword.Text = _perfil.Password;
        }
    }
}
