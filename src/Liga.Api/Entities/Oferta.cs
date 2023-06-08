namespace Liga.Api.Entities
{
    public class Oferta
    {
        public int Id { get; set; }
        public int OfertaEstadoId { get; set; }
        public decimal Valor { get; set; }
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }
    }
}
