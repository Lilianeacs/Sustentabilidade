namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
{
    public sealed record CreateSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TipoMaquina { get; set; }
        public string TipoMaterial { get; set; }
    }
}
