using AutoMapper;
using GarageSoft.Application.Contracts.Persistence;
using GarageSoft.Domain.Entities;
using GarageSoft.Shared.DTOs.Client;
using MediatR;

namespace GarageSoft.Application.Features.Clients.Commands.Create;

public record AddClientCommand(CreateClientDto Client) : IRequest<bool>;

 class AddClientCommandHandler(IClientRepository _clientRepository,
                               IMapper _mapper) : IRequestHandler<AddClientCommand, bool>
{
    public async Task<bool> Handle(AddClientCommand request, CancellationToken cancellationToken)
    {
        var clientEntity = _mapper.Map<Client>(request.Client);
        var result = await  _clientRepository.AddAsync(clientEntity);
        return result > 0;
    }
}
