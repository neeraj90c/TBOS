using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Agent;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Agent
{
    public class DeleteAgentCommand : IRequest<Unit>
    {
        public DeleteAgent deleteAgent {  get; set; }
    }

    internal class DeleteAgentCommandHandler : IRequestHandler<DeleteAgentCommand, Unit>
    {
        protected readonly IAgentMaster _agentMaster;
        public DeleteAgentCommandHandler(IAgentMaster agentMaster)
        {
            _agentMaster = agentMaster;
        }

        public async Task<Unit> Handle(DeleteAgentCommand request, CancellationToken cancellationToken)
        {
            return await _agentMaster.Delete(request.deleteAgent);
        }
    }
}
