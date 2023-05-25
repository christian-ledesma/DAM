using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Liga.FormUI.CustomControls
{
    public partial class Noticia : UserControl
    {
        public Noticia()
        {
            InitializeComponent();
        }

        private string _titulo;
        private string _descripcion;

        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; labelTitulo.Text = value; }
        }
        [Category("Custom Props")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; labelDescripcion.Text = value; }
        }
    }
}
