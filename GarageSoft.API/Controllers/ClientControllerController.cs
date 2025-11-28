using Azure;
using GarageSoft.Application.Features.Clients.Queries.GetAll;
using GarageSoft.Shared.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarageSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientControllerController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("{clientId}")]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAll()
        {
           var result = await _mediator.Send(new GetAllClientQuery());
            return Ok(result);
        }
    }
}
