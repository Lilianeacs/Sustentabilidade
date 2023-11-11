using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Entities
{
    public class ServiceOrder : BaseEntity
    {
        public DateTimeOffset EstimatedDate { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ServiceID { get; set; }
        public List<EServiceStatus> Status { get; set; }
    }
}
