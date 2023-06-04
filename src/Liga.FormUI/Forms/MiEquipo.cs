using Liga.FormUI.CustomControls;
using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class MiEquipo : Form
    {
        private readonly int _usuarioId;
        private readonly EquipoService _equipoService;
        private readonly JugadorService _jugadorService;

        private EquipoDto _equipo;
        private IEnumerable<JugadorDto> _jugadores;

        public MiEquipo(int usuarioId)
        {
            _usuarioId = usuarioId;
            _equipoService = new EquipoService();
            _jugadorService = new JugadorService();
            InitializeComponent();
        }

        private async void MiEquipo_Load(object sender, System.EventArgs e)
        {
            var equipo = await _equipoService.GetByEntrenador(_usuarioId);
            var jugadores = await _jugadorService.GetJugadoresInTeam(equipo.Id);

            _equipo = equipo;
            _jugadores = jugadores;

            Populate();
        }

        private void Populate()
        {
            var jugadorItems = new JugadorItem[_jugadores.Count()];

            for (int i = 0; i < _jugadores.Count(); i++)
            {
                var nombreCompleto = $"{_jugadores.ToArray()[i].Nombre} {_jugadores.ToArray()[i].Apellidos}";
                jugadorItems[i] = new JugadorItem
                {
                    Id = _jugadores.ToArray()[i].Id,
                    NombreCompleto = nombreCompleto,
                    Nombre = _jugadores.ToArray()[i].Nombre,
                    Apellidos = _jugadores.ToArray()[i].Apellidos,
                    Dorsal = _jugadores.ToArray()[i].Dorsal,
                    Pais = _jugadores.ToArray()[i].Nacionalidad,
                    Posicion = _jugadores.ToArray()[i].Posicion
                };
            }

            textBoxPresupuesto.Text = $"{_equipo.Presupuesto.ToString()} €";
            textBoxEstadio.Text = _equipo.Estadio;
            textBoxUbicacion.Text = _equipo.Ubicacion;

            flowLayoutPanel1.Controls.AddRange(jugadorItems);
        }

    }
}
