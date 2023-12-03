using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._ServiceOrder.CreateServiceOrder
{
    public class CreateServiceOrderHandler : IRequestHandler<CreateServiceOrderRequest, CreateServiceOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IProductRepository _productRepository;

        public CreateServiceOrderHandler(IUnitOfWork unitOfWork, 
                                        IServiceOrderRepository serviceOrderRepository,
                                        IMapper mapper,
                                        IServiceRepository serviceRepository,
                                        ISupplierRepository supplierRepository,
                                        IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
            _serviceRepository = serviceRepository;
            _supplierRepository = supplierRepository;
            _productRepository = productRepository;
        }

        public async Task<CreateServiceOrderResponse> Handle(CreateServiceOrderRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var serviceOrder = _mapper.Map<ServiceOrder>(request);

                var service = await _serviceRepository.Get(request.ServiceId, cancellationToken);
                var supplier = await _supplierRepository.Get(request.SupplierId, cancellationToken);
                var product = await _productRepository.Get(service.ProductId, cancellationToken);

                if (service == null) { throw new ArgumentException("Service not found"); }
                if (supplier == null) { throw new ArgumentException("Supplier not found"); }
            
                var now = DateTime.Now;
                serviceOrder.EstimatedDate = now.AddDays(service.ServiceDays);

                bool haveSewingMachine = service.SewingMachine
                    .All(item => supplier.ESewingMachine.Contains(item));
                bool usesMaterial = product.Materials
                    .All(item => supplier.EMaterials.Contains(item));

                if (!haveSewingMachine || !usesMaterial) { serviceOrder.Status = EServiceStatus.REJECTED; }

                _serviceOrderRepository.Create(serviceOrder);

                await _unitOfWork.Commit(cancellationToken);
                return _mapper.Map<CreateServiceOrderResponse>(serviceOrder);

            } catch (Exception) { throw; }
        }
    }
}