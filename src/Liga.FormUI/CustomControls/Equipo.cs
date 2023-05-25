using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Liga.FormUI.CustomControls
{
    public partial class Equipo : UserControl
    {
        public Equipo()
        {
            InitializeComponent();
        }

        private string _nombre;
        private string _director;
        private string _clasificacion;
        private string _ubicacion;
        private string _victorias;
        private string _derrotas;
        private Image _image;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; labelNombre.Text = value; }
        }
        [Category("Custom Props")]
        public string Director
        {
            get { return _director; }
            set { _director = value; labelDirector.Text = value; }
        }
        [Category("Custom Props")]
        public string Clasificacion
        {
            get { return _clasificacion; }
            set { _clasificacion = value; labelClasificacion.Text = value; }
        }
        [Category("Custom Props")]
        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; labelUbicacion.Text = value; }
        }
        [Category("Custom Props")]
        public string Victorias
        {
            get { return _victorias; }
            set { _victorias = value; labelVictorias.Text = value; }
        }
        [Category("Custom Props")]
        public string Derrotas
        {
            get { return _derrotas; }
            set { _derrotas = value; labelDerrotas.Text = value; }
        }
        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
    }
}
