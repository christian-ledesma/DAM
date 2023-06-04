namespace Liga.Api.DTOs
{
    public class JugadorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public decimal Valor { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public int Dorsal { get; set; }
    }
}
