using AutoMapper;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderById
{
    public sealed class GetServiceOrderByIdHandler : IRequestHandler<GetServiceOrderByIdRequest, GetServiceOrderByIdResponse>
    {
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;

        public GetServiceOrderByIdHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper)
        {
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
        }

        public async Task<GetServiceOrderByIdResponse> Handle(GetServiceOrderByIdRequest request, CancellationToken cancellationToken)
        {
            var serviceOrder = await _serviceOrderRepository.Get(request.Id, cancellationToken);
            return _mapper.Map<GetServiceOrderByIdResponse>(serviceOrder);
        }
    }
}
