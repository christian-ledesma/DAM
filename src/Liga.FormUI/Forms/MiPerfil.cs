using System;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class MiPerfil : Form
    {
        public MiPerfil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagePath = string.Empty;
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
        }
    }
}
