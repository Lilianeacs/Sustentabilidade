using Twilio.TwiML.Voice;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._ServiceOrder.CreateServiceOrder
{
    public sealed record CreateServiceOrderResponse
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTime EstimatedDate { get; set; }
        public EServiceStatus Status { get; set; }
        public bool Payed { get; set; }
    }
}