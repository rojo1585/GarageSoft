using AutoMapper;
using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Shared.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageSoft.Application.Features.Clients.Queries.GetAll;

public record GetAllClientQuery : IRequest<IEnumerable<ClientDto>>;
public class GetAllClientQueryHandler(IClientRepository _clientRepository,
                                      IMapper _mapper) : IRequestHandler<GetAllClientQuery, IEnumerable<ClientDto>>
{
    public async Task<IEnumerable<ClientDto>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
    {
        var clients = await _clientRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ClientDto>>(clients);
    }
}
