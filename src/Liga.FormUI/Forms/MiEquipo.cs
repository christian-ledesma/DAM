using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System.Collections.Generic;
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
        }
    }
}
