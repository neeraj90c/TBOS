using Application.DTOs.SupportDesk;
using Application;
using Application.Interfaces;
using Domain.Settings;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.DTOs.TBOS.Masters;
using Application.Features.TBOS.Masters.Branch;

namespace WebAPI.Controllers.TBOS.Masters.Branch
{
    [Route("TBOS/BranchMaster")]
    public class BranchMasterController : BaseApiController
    {
        APISettings _settings;

        public BranchMasterController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateBranch createBranch)
        {
            BranchMasterDTO response = new BranchMasterDTO();


            response = await mediator.Send(new CreateBranchCommand
            {
                createBranch = createBranch
            }); 

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadByCompanyId")]
        public async Task<IActionResult> ReadByCompanyId(int CompanyId)
        {
            BranchList response = new BranchList();


            response = await mediator.Send(new ReadByCompanyIdCommand
            {
                CompanyId = CompanyId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadByBranchId")]
        public async Task<IActionResult> ReadByBranchId(int BranchId)
        {
            BranchMasterDTO response = new BranchMasterDTO();


            response = await mediator.Send(new ReadByIdCommand
            {
                BranchId = BranchId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(UpdateBranch updateBranch)
        {
            BranchMasterDTO response = new BranchMasterDTO();


            response = await mediator.Send(new UpdateCommand
            {
               updateBranch = updateBranch
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
