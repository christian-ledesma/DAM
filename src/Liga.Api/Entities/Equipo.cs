using System.Collections.Generic;

namespace Liga.Api.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public int Puntos { get; set; }
        public decimal Presupuesto { get; set; }
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int PartidosEmpatados { get; set; }
        public IEnumerable<Jugador> Jugadores { get; set; }
    }
}
