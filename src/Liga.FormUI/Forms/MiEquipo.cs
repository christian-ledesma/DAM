using Liga.FormUI.DTOs;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class MiEquipo : Form
    {
        private readonly EquipoDto _equipo;
        public MiEquipo(EquipoDto equipo, IEnumerable<JugadorDto> jugadores)
        {
            _equipo = equipo;
            InitializeComponent();
            RellenarGrid(jugadores);
        }

        private void RellenarGrid(IEnumerable<JugadorDto> jugadores)
        {
            foreach (var jugador in jugadores)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[index];

                row.Cells[0].Value = jugador.Nombre;
                row.Cells[1].Value = jugador.Apellidos;
                row.Cells[2].Value = jugador.Nacionalidad;
                row.Cells[3].Value = jugador.Dorsal;
            }
        }

        private void MiEquipo_Load(object sender, System.EventArgs e)
        {
            var height = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }

            dataGridView1.Height = height;
        }
    }
}
