using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Service.UpdateService
{
    public class UpdateServiceHandler : IRequestHandler<UpdateServiceRequest, UpdateServiceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _ServiceRepository;
        private readonly IMapper _mapper;

        public UpdateServiceHandler(IUnitOfWork unitOfWork, IServiceRepository ServiceRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _ServiceRepository = ServiceRepository;
            _mapper = mapper;
        }

        public async Task<UpdateServiceResponse> Handle(UpdateServiceRequest request, CancellationToken cancellationToken)
        {
            var Service = await _ServiceRepository.Get(request.Id, cancellationToken);

            if (Service == null)
                return default;

            _ServiceRepository.Update(Service);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<UpdateServiceResponse>(Service);
        }
    }
}
