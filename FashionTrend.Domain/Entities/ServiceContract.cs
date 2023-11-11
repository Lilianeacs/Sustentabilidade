namespace FashionTrend.Domain.Entities
{
    public class ServiceContract
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }

    }
}
