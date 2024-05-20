using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Agent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Agent
{
    public class ReadByAgentIdCommand : IRequest<AgentMasterDTO>
    {
        public int AgentId { get; set; }
    }

    internal class ReadByAgentIdCommandHandler : IRequestHandler<ReadByAgentIdCommand, AgentMasterDTO>
    {
        protected readonly IAgentMaster _agentMaster;
        public ReadByAgentIdCommandHandler(IAgentMaster agentMaster)
        {
            _agentMaster = agentMaster;
        }

        public async Task<AgentMasterDTO> Handle(ReadByAgentIdCommand request, CancellationToken cancellationToken)
        {
            return await _agentMaster.ReadById(request.AgentId);
        }
    }
}
