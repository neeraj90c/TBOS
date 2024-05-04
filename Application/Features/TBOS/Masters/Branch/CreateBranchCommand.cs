using Application.DTOs;
using Application.DTOs.LeadGeneration;
using Application.DTOs.TBOS.Masters;
using Application.Features.LeadGeneration.Commands;
using Application.Features.Shipments.Commands;
using Application.Interfaces;
using Application.Interfaces.LeadGeneration;
using Application.Interfaces.TBOS.Masters.Branch;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Branch
{
    public class CreateBranchCommand : IRequest<BranchMasterDTO>
    {
        public CreateBranch createBranch { get; set; }
    }

    internal class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, BranchMasterDTO>
    {
        protected readonly IBranchMaster _branchMasterService;

        public CreateBranchCommandHandler(IBranchMaster branchMasterService)
        {
            _branchMasterService = branchMasterService;
        }

        public async Task<BranchMasterDTO> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            return await _branchMasterService.Create(request.createBranch);
        }
    }

}
