namespace Liga.Api.DTOs
{
    public class UsuarioLoginResponse : ResponseBase
    {
        public int UsuarioId { get; set; }
        public bool EsAdmin { get; set; }
    }
}
