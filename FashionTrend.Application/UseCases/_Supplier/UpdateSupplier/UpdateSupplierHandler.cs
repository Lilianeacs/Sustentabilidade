using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.UpdateSupplier
{
    public class UpdateSupplierHandler : IRequestHandler<UpdateSupplierRequest, UpdateSupplierResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public UpdateSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSupplierResponse> Handle(UpdateSupplierRequest request, CancellationToken cancellationToken)
        {
            var supplier = await _supplierRepository.Get(request.Id, cancellationToken);

            if (supplier == null)
                return default;

            _supplierRepository.Update(supplier);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<UpdateSupplierResponse>(supplier);
        }
    }
}
