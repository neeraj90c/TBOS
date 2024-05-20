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
    public class ReadAllAgentCommand : IRequest<AgentList>
    {
    }

    internal class ReadAllAgentCommandHandler : IRequestHandler<ReadAllAgentCommand, AgentList>
    {
        protected readonly IAgentMaster _agentMaster;
        public ReadAllAgentCommandHandler(IAgentMaster agentMaster)
        {
            _agentMaster = agentMaster;
        }

        public async Task<AgentList> Handle(ReadAllAgentCommand request, CancellationToken cancellationToken)
        {
            return await _agentMaster.ReadAll();
        }
    }
}
