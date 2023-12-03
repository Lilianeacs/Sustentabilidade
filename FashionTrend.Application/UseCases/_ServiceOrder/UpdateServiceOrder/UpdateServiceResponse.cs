﻿using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._ServiceOrder.UpdateServiceOrder
{
    public sealed record UpdateServiceOrderResponse
    {   
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTime EstimatedDate { get; set; }
        public EServiceStatus Status { get; set; }
        public bool Payed { get; set; }
    }
}
