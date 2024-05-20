using Application.DTOs.TBOS.Masters;
using Application.Features.TBOS.Masters.Agent;
using Application;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.Features.TBOS.Masters.Agent;
using Application.Features.TBOS.Masters.Agent;
using Application.Features.TBOS.Masters.Agent;

namespace WebAPI.Controllers.TBOS.Masters.Agent
{
    [Route("TBOS/AgentMaster")]
    public class AgentMasterController : BaseApiController
    {
        APISettings _settings;
        public AgentMasterController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            AgentList response = new AgentList();


            response = await mediator.Send(new ReadAllAgentCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateAgent createAgent)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            response = await mediator.Send(new CreateAgentCommand
            {
                createAgent = createAgent
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAgent updateAgent)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            response = await mediator.Send(new UpdateAgentCommand
            {
                updateAgent = updateAgent
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadById/{AgentId}")]
        public async Task<IActionResult> ReadById(int AgentId)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            response = await mediator.Send(new ReadByAgentIdCommand
            {
                AgentId = AgentId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAgent deleteAgent)
        {
            await mediator.Send(new DeleteAgentCommand
            {
                deleteAgent = deleteAgent
            });

            return Ok();
        }
    }
}
