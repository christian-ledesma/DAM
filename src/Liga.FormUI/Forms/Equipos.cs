using Liga.FormUI.CustomControls;
using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class Equipos : Form
    {
        private IEnumerable<EquipoDto> _equipos;
        private readonly EquipoService _equipoService;

        public Equipos()
        {
            _equipoService = new EquipoService();
            InitializeComponent();
        }

        private async void Equipos_Load(object sender, EventArgs e)
        {
            _equipos = await _equipoService.GetAll();

            FillGrid();
        }

        private void FillGrid()
        {
            var equiposItems = new Equipo[_equipos.Count()];
            for (int i = 0; i < _equipos.Count(); i++)
            {
                equiposItems[i] = new Equipo
                {
                    Nombre = _equipos.ToArray()[i].Nombre,
                    Director = _equipos.ToArray()[i].EntrenadorId.ToString(),
                    Clasificacion = $"Posición: {i + 1}",
                    Ubicacion = _equipos.ToArray()[i].Ubicacion,
                    Victorias = $"{_equipos.ToArray()[i].PartidosGanados.ToString()} Victorias",
                    Derrotas = $"{_equipos.ToArray()[i].PartidosPerdidos.ToString()} Derrotas"
                };
            }
            flowLayoutPanel1.Controls.AddRange(equiposItems);
        }
    }
}
