using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid ContractId { get; set; }
        public decimal Amount { get; set; }
        public EPaymentMethod PaymentMethod { get; set; }
        public DateTimeOffset PaymentDate { get; set; }
    }
}
