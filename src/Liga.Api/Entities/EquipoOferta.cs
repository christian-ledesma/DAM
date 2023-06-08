namespace Liga.Api.Entities
{
    public class EquipoOferta
    {
        public int Id { get; set; }
        public int EquipoOfertanteId { get; set; }
        public int EquipoOfertadoId { get; set; }
        public int OfertaId { get; set; }
    }
}
