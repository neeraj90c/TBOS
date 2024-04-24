using Application.DTOs.TBOS.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Masters.Branch
{
    public interface IBranchMaster
    {
        public Task<BranchMasterDTO> Create(CreateBranch createBranch);
        public Task<BranchList> ReadByCompanyId(int CompanyId);
        public Task<BranchMasterDTO> ReadById(int BranchId);
        public Task<BranchMasterDTO> Update(UpdateBranch updateBranch);
    }
}
