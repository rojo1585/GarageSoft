using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Shared.DTOs;
using MediatR;

namespace GarageSoft.Application.Features.Statistics.Queries;

public record GetAllStatisticsQuery : IRequest<StatisticsDto>;

 class GetAllStatisticsQueryHandler(IClientRepository _clientRepository,
                                    IServiceRepository _serviceRepository) : IRequestHandler<GetAllStatisticsQuery, StatisticsDto>
{
    public async  Task<StatisticsDto> Handle(GetAllStatisticsQuery request, CancellationToken cancellationToken)
    {

        var clientTask = _clientRepository.CountAsync();
        var serviceTask = _serviceRepository.CountAsync();
        var veichleTask = _serviceRepository.CountAsync();

       await Task.WhenAll(clientTask, serviceTask, veichleTask);
        var statistics = new StatisticsDto
        {
            ClinetsCount = clientTask.Result,
            VehiclesCount = serviceTask.Result,
            ServicesCout = veichleTask.Result,
            OverdueServices = 10
        };
        return statistics;
    }
}