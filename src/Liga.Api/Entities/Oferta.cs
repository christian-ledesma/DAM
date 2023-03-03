namespace Liga.Api.Entities
{
    public class Oferta
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int OfertaTipoId { get; set; }
        public OfertaTipo OfertaTipo { get; set; }
        public int OfertaEstadoId { get; set; }
        public OfertaEstado Estado { get; set; }
    }
}
