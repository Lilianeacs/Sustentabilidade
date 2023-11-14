using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.GetAllSupplier
{
    public class GetAllSupplierHandler : IRequestHandler<GetAllSupplierRequest, List<GetAllSupplierResponse>>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;  
        

        public GetAllSupplierHandler(ISupplierRepository supplierRepository,
            IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllSupplierResponse>> Handle(GetAllSupplierRequest request, CancellationToken cancellationToken)
        {
            var suppliers = await _supplierRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetAllSupplierResponse>>(suppliers);
        }

    }
}
