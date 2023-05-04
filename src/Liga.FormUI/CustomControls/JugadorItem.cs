using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Liga.FormUI.CustomControls
{
    public partial class JugadorItem : UserControl
    {
        public JugadorItem()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, System.EventArgs e)
        {
        }

        private string _nombreCompleto;
        private string _pais;
        private string _posicion;
        private Image _image;

        [Category("Custom Props")]
        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; labelNombre.Text = value; }
        }
        [Category("Custom Props")]
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; labelPais.Text = value; }
        }
        [Category("Custom Props")]
        public string Posicion
        {
            get { return _posicion; }
            set { _posicion = value; labelPosicion.Text = value; }
        }
        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
    }
}
