using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._Service.GetAllService
{
    public class GetAllServiceHandler : IRequestHandler<GetAllServiceRequest, List<GetAllServiceResponse>>
    {
        private readonly IServiceRepository _ServiceRepository;
        private readonly IMapper _mapper;  
        

        public GetAllServiceHandler(IServiceRepository ServiceRepository,
            IMapper mapper)
        {
            _ServiceRepository = ServiceRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllServiceResponse>> Handle(GetAllServiceRequest request, CancellationToken cancellationToken)
        {
            var Services = await _ServiceRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetAllServiceResponse>>(Services);
        }

    }
}
