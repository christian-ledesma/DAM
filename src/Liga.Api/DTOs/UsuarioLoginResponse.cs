﻿namespace Liga.Api.DTOs
{
    public class UsuarioLoginResponse : ResponseBase
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] ImagenBytes { get; set; }
        public bool Admin { get; set; }
    }
}
