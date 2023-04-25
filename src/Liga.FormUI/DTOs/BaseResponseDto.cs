namespace Liga.FormUI.DTOs
{
    public class BaseResponseDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Content { get; set; }
    }
}
