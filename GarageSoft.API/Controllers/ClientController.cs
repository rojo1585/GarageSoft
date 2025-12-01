using GarageSoft.Application.Features.Clients.Commands.Create;
using GarageSoft.Application.Features.Clients.Queries.GetAll;
using GarageSoft.Shared.DTOs.Client;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GarageSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllClientQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult> Post(CreateClientDto client)
        {
            var result = await _mediator.Send(new AddClientCommand(client));
            return result ? Created() : BadRequest();
        }
    }
}
