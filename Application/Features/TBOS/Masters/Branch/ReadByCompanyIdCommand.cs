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
    public class ReadByCompanyIdCommand : IRequest<BranchList>
    {
        public int CompanyId { get; set; }
    }

    internal class ReadByCompanyIdCommandHandler : IRequestHandler<ReadByCompanyIdCommand, BranchList>
    {

        protected readonly IBranchMaster _branchMasterService;

        public ReadByCompanyIdCommandHandler(IBranchMaster branchMasterService)
        {
            _branchMasterService = branchMasterService;
        }
        public async Task<BranchList> Handle(ReadByCompanyIdCommand request, CancellationToken cancellationToken)
        {
            return await _branchMasterService.ReadByCompanyId(request.CompanyId);
        }
    }
}
