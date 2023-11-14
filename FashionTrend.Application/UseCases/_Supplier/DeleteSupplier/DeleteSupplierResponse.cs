namespace FashionTrend.Application.UseCases._Supplier.DeleteSupplier
{
    public sealed record DeleteSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TipoMaquina { get; set; }
        public string TipoMaterial { get; set; }
    }
}
