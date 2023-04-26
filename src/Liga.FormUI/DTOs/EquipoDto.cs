﻿namespace Liga.FormUI.DTOs
{
    public class EquipoDto
    {
        public int Id { get; set; }
        public int EntrenadorId { get; set; }
        public int Puntos { get; set; }
        public decimal Presupuesto { get; set; }
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public string ImagenUrl { get; set; }
        public string Ubicacion { get; set; }
        public string Estadio { get; set; }
    }
}
