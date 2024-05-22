using Application.DTOs.TBOS.UserControl;
using Application.Features.TBOS.UC.Address;
using Application;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace WebAPI.Controllers.TBOS.UC.Address
{
    [Route("TBOS/AddressDetail")]
    public class AddressDetailController : BaseApiController
    {
        APISettings _settings;
        public AddressDetailController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            AddressList response = new AddressList();


            response = await mediator.Send(new ReadAllAddressCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateAddress createAddress)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            response = await mediator.Send(new CreateAddressCommand
            {
                createAddress = createAddress
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAddress updateAddress)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            response = await mediator.Send(new UpdateAddressCommand
            {
                updateAddress = updateAddress
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadById/{DetailId}")]
        public async Task<IActionResult> ReadById(int DetailId)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            response = await mediator.Send(new ReadByDetailIdCommand
            {
                DetailId = DetailId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAddress deleteAddress)
        {
            await mediator.Send(new DeleteAddressCommand
            {
                deleteAddress = deleteAddress
            });

            return Ok();
        }

        [HttpGet("ReadByMasterCode/{MasterCode}")]
        public async Task<IActionResult> ReadByMasterCode(string MasterCode)
        {
            AddressList response = new AddressList();
            response = await mediator.Send(new ReadAddressByMasterCodeCommand
            {
                MasterCode = MasterCode
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadByMasterCodeDefault/{MasterCode}")]
        public async Task<IActionResult> ReadByMasterCodeDefault(string MasterCode)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            response = await mediator.Send(new ReadAddressByMasterCodeDefaultCommand
            {
                MasterCode = MasterCode
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
