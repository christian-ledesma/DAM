﻿namespace Liga.Api.Entities
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public decimal Valor { get; set; }
        public int PosicionId { get; set; }
        public int EquipoId { get; set; }
        public int Edad { get; set; }
        public int Dorsal { get; set; }
    }
}
