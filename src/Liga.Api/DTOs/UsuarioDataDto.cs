namespace Liga.Api.DTOs
{
    public class UsuarioDataDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] ImagenBytes { get; set; }
    }
}
