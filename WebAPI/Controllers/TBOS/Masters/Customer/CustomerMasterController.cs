using Application;
using Application.DTOs.TBOS.Common;
using Application.DTOs.TBOS.Masters;
using Application.Features.TBOS.Masters.Branch;
using Application.Features.TBOS.Masters.Customer;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace WebAPI.Controllers.TBOS.Masters.Customer
{
    [Route("TBOS/CustomerMaster")]
    public class CustomerMasterController : BaseApiController
    {
        APISettings _settings;

        public CustomerMasterController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateCustomer createCustomer)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();


            response = await mediator.Send(new CreateCustomerCommand
            {
                createCustomer = createCustomer
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomer updateCustomer)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();


            response = await mediator.Send(new UpdateCustomerCommand
            {
                updateCustomer = updateCustomer
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            CustomerList response = new CustomerList();


            response = await mediator.Send(new ReadAllCustomerCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("ReadAllPaginated")]
        public async Task<IActionResult> ReadAllPaginated([FromBody]PaginatedDTO paginatedDTO)
        {
            CustomerListPaginated response = new CustomerListPaginated();


            response = await mediator.Send(new ReadAllCustomerPaginated 
            {
                paginatedDTO = paginatedDTO
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadById/{CustomerId}")]
        public async Task<IActionResult> ReadByCustomerId(int CustomerId)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();


            response = await mediator.Send(new ReadByCustomerIdCommand 
            {
                CustomerId = CustomerId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(DeleteCustomer deleteCustomer)
        {
            CustomerList response = new CustomerList();


            response = await mediator.Send(new DeleteCustomerCommand
            {
                deleteCustomer = deleteCustomer
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
