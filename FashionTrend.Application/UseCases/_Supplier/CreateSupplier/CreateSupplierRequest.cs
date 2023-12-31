﻿using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
{
    public sealed record CreateSupplierRequest(
        string Name,
        string Email,
        string Password,
        List<ESewingMachine> MachineType,
        List<EMaterial> MaterialType
        ) : IRequest<CreateSupplierResponse>;
}
