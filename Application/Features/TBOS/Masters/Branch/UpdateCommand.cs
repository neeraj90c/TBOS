using Application.DTOs.TBOS.Masters;
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
    public class UpdateCommand : IRequest<BranchMasterDTO>
    {
        public UpdateBranch updateBranch { get; set; }
    }

    internal class UpdateCommandHandler : IRequestHandler<UpdateCommand, BranchMasterDTO>
    {
        protected readonly IBranchMaster _branchMasterService;

        public UpdateCommandHandler(IBranchMaster branchMasterService)
        {
            _branchMasterService = branchMasterService;
        }

        public async Task<BranchMasterDTO> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            return await _branchMasterService.Update(request.updateBranch);
        }
    }
}
