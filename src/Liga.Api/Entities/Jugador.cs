namespace Liga.Api.Entities
{
    public class Jugador
    {
        public int Id { get; set; }
        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipo { get; set; }
    }
}
