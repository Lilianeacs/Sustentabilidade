using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public class CreateSupplierHandler : IRequestHandler<CreateSupplierRequest, CreateSupplierResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public CreateSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public Task<CreateSupplierResponse> Handle(CreateSupplierRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<CreateSupplierResponse> Handler(CreateSupplierRequest request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Supplier>(request);

            _supplierRepository.Create(supplier);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateSupplierResponse>(supplier);
        }
    }
}
