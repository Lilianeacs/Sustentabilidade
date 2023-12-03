using static FashionTrend.Domain.Entities.ConstantClasses;
namespace FashionTrend.Domain.Entities
{
    public class ServiceContract : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public List<EContractStatus> Status { get; set; }

    }
}
