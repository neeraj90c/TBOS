using Application.DTOs.TBOS.Masters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Masters.Agent
{
    public interface IAgentMaster
    {
        public Task<AgentList> ReadAll();
        public Task<AgentMasterDTO> Create(CreateAgent createAgent);
        public Task<AgentMasterDTO> Update(UpdateAgent updateAgent);
        public Task<AgentMasterDTO> ReadById(int AgentId);
        public Task<Unit> Delete(DeleteAgent deleteAgent);
    }
}
