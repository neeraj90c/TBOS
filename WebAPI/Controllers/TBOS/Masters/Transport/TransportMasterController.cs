using Application.DTOs.TBOS.Masters;
using Application.Features.TBOS.Masters.Customer;
using Application;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.Features.TBOS.Masters.Transport;

namespace WebAPI.Controllers.TBOS.Masters.Transport
{
    [Route("TBOS/TransportMaster")]
    public class TransportMasterController : BaseApiController
    {
        APISettings _settings;
        public TransportMasterController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            TransportList response = new TransportList();


            response = await mediator.Send(new ReadAllTransportCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateTransport createTransport)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            response = await mediator.Send(new CreateTransportCommand
            {
                createTransport = createTransport
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateTransport updateTransport)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            response = await mediator.Send(new UpdateTransportCommand
            {
                updateTransport = updateTransport
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadById/{TransportId}")]
        public async Task<IActionResult> ReadById(int TransportId)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            response = await mediator.Send(new ReadByTransportIdCommand
            {
                TransportId = TransportId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteTransport deleteTransport)
        {
             await mediator.Send(new DeleteTransportCommand
            {
                 deleteTransport = deleteTransport
             });

            return Ok();
        }
    }
}
