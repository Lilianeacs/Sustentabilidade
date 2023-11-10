namespace FashionTrend.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MachineType { get; set; }
        public string MaterialType { get; set; }
    }
}
