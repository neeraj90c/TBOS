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
    public class UpdateAgentCommand : IRequest<AgentMasterDTO>
    {
        public UpdateAgent updateAgent { get; set; }
    }
    internal class UpdateAgentCommandHandler : IRequestHandler<UpdateAgentCommand, AgentMasterDTO>
    {
        protected readonly IAgentMaster _agentMaster;
        public UpdateAgentCommandHandler(IAgentMaster agentMaster)
        {
            _agentMaster = agentMaster;
        }

        public async Task<AgentMasterDTO> Handle(UpdateAgentCommand request, CancellationToken cancellationToken)
        {
            return await _agentMaster.Update(request.updateAgent);
        }
    }
}

