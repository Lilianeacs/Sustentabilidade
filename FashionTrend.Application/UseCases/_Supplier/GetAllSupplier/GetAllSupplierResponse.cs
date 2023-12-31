﻿using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Supplier.GetAllSupplier
{
    public sealed record GetAllSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ConstantClasses.ESewingMachine> MachineType { get; set; }
        public List<ConstantClasses.EMaterial> MaterialType { get; set; }
    }
}
