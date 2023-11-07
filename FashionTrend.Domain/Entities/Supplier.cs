namespace FashionTrend.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TipoMaquina { get; set; }
        public string TipoMaterial { get; set; }
    }
}
