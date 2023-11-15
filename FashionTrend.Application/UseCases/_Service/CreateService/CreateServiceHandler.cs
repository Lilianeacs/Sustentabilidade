using AutoMapper;
using FashionTrend.Application.UseCases._Service.CreateService;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public class CreateServiceHandler : IRequestHandler<CreateServiceRequest, CreateServiceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _ServiceRepository;
        private readonly IMapper _mapper;

        public CreateServiceHandler(IUnitOfWork unitOfWork, IServiceRepository ServiceRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _ServiceRepository = ServiceRepository;
            _mapper = mapper;
        }

        public async Task<CreateServiceResponse> Handle(CreateServiceRequest request, CancellationToken cancellationToken)
        {
            var Service = _mapper.Map<Service>(request);

            _ServiceRepository.Create(Service);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateServiceResponse>(Service);
        }
    }
}