using Application.DTOs.TBOS.Masters;
using Application.Features.TBOS.Masters.Transport;
using Application;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.Features.TBOS.UC.Contact;
using Application.DTOs.TBOS.UserControl;

namespace WebAPI.Controllers.TBOS.UC.Contact
{
    [Route("TBOS/ContactDetail")]
    public class ContactDetailController : BaseApiController
    {
        APISettings _settings;
        public ContactDetailController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            ContactList response = new ContactList();


            response = await mediator.Send(new ReadAllContactCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateContact createContact)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            response = await mediator.Send(new CreateContactCommand
            {
                createContact = createContact
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateContact updateContact)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            response = await mediator.Send(new UpdateContactCommand
            {
                updateContact = updateContact
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadById/{ContactId}")]
        public async Task<IActionResult> ReadById(int ContactId)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            response = await mediator.Send(new ReadByContactIdCommand
            {
                ContactId = ContactId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContact deleteContact)
        {
            await mediator.Send(new DeleteContactCommand
            {
                deleteContact = deleteContact
            });

            return Ok();
        }

        [HttpGet("ReadByMasterCode/{MasterCode}")]
        public async Task<IActionResult> ReadByMasterCode(string MasterCode)
        {
            ContactList response = new ContactList();
            response = await mediator.Send(new ReadContactByMasterCodeCommand
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
            ContactDetailDTO response = new ContactDetailDTO();
            response = await mediator.Send(new ReadContactByMasterCodeDefaultCommand
            {
                MasterCode = MasterCode
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
