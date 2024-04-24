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
    public class ReadByIdCommand : IRequest<BranchMasterDTO>
    {
        public int BranchId { get; set; }   
    }

    internal class ReadByIdCommandHandler : IRequestHandler<ReadByIdCommand, BranchMasterDTO>
    {
        protected readonly IBranchMaster _branchMasterService;

        public ReadByIdCommandHandler(IBranchMaster branchMasterService)
        {
            _branchMasterService = branchMasterService;
        }
        public async Task<BranchMasterDTO> Handle(ReadByIdCommand request, CancellationToken cancellationToken)
        {
            return await _branchMasterService.ReadById(request.BranchId);
        }
    }
}
