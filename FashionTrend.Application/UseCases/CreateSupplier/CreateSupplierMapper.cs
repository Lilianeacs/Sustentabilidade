using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public class CreateSupplierMapper : Profile
    {
        public CreateSupplierMapper() 
        {
            CreateMap<CreateSupplierRequest, Supplier>();
            CreateMap<Supplier, CreateSupplierResponse>();
        }
    }
}
