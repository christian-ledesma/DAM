namespace Liga.FormUI.DTOs
{
    public class UsuarioLoginResponse : BaseResponseDto
    {
        public int UsuarioId { get; set; }
        public bool EsAdmin { get; set; }
    }
}
