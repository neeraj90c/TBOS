using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Agent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Agent
{
    public class CreateAgentCommand : IRequest<AgentMasterDTO>
    {
        public CreateAgent createAgent { get; set; }
    }
    internal class CreateAgentCommandHandler : IRequestHandler<CreateAgentCommand, AgentMasterDTO>
    {
        protected readonly IAgentMaster _agentMaster;   
        public CreateAgentCommandHandler(IAgentMaster agentMaster)
        {
            _agentMaster = agentMaster;
        }

        public async Task<AgentMasterDTO> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {
            return await _agentMaster.Create(request.createAgent);
        }
    }
}
