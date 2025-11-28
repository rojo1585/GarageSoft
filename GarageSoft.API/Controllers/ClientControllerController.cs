using Azure;
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
        public async Task<ActionResult<Response<int?>>> GetJustBalnce(int clientId)
        {
            return Ok();
        }
    }
}
