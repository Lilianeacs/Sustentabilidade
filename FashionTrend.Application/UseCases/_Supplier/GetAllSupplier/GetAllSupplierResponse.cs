namespace FashionTrend.Application.UseCases._Supplier.GetAllSupplier
{
    public sealed record GetAllSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TipoMaquina { get; set; }
        public string TipoMaterial { get; set; }
    }
}
