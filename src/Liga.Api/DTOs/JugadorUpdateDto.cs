namespace Liga.Api.DTOs
{
    public class JugadorUpdateDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public int Dorsal { get; set; }
    }
}
