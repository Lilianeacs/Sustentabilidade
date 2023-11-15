using AutoMapper;
using FashionTrend.Application.UseCases._Service;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Service.DeleteService
{
    public class DeleteServiceHandler : IRequestHandler<DeleteServiceRequest, DeleteServiceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceRepository _ServiceRepository;
        private readonly IMapper _mapper;

        public DeleteServiceHandler(IUnitOfWork unitOfWork, IServiceRepository ServiceRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _ServiceRepository = ServiceRepository;
            _mapper = mapper;
        }

        
        public async Task<DeleteServiceResponse> Handle(DeleteServiceRequest request, CancellationToken cancellationToken)
        {
            var Service = await _ServiceRepository.Get(request.Id, cancellationToken);
            if (Service == null)
                return default;
            _ServiceRepository.Delete(Service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceResponse>(Service);
        }
    }
}
