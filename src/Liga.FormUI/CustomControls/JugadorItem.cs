using Liga.FormUI.DTOs;
using Liga.FormUI.Modals;
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

        private int _id;
        private string _nombreCompleto;
        private string _nombre;
        private string _apellidos;
        private string _pais;
        private string _posicion;
        private int _dorsal;
        private Image _image;

        private void customButton1_Click(object sender, System.EventArgs e)
        {
            using UpdateJugadorDialog dialog = new UpdateJugadorDialog();
            dialog.Nombre = _nombre;
            dialog.Apellido = _apellidos;
            dialog.Nacionalidad = _pais;
            dialog.Dorsal = _dorsal;
            dialog.Id = _id;
            dialog.ShowDialog();
        }

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        [Category("Custom Props")]
        public int Dorsal
        {
            get { return _dorsal; }
            set { _dorsal = value; }
        }
        [Category("Custom Props")]
        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; labelNombre.Text = value; }
        }
        [Category("Custom Props")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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
