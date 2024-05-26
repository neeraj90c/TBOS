using Application.DTOs.TBOS.Ref.ValueList;
using Application.Features.TBOS.Ref.ValueList;
using Application;
using Domain.Settings;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.Features.TBOS.Ref.ValueListItem;

namespace WebAPI.Controllers.TBOS.Ref.ValueListItem
{
    [Route("TBOS/ValueListItem")]
    public class ValueListItemController : BaseApiController
    {
        APISettings _settings;
        public ValueListItemController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadByValueListId/{ValuesListId}")]
        public async Task<IActionResult> ReadByValueListId(int ValuesListId)
        {
            ValueListItemAll response = new ValueListItemAll();


            response = await mediator.Send(new ReadByValueListIdCommand 
            {
                ValuesListId = ValuesListId
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpGet("ReadByVLName/{vlName}")]
        public async Task<IActionResult> ReadByVLName(string vlName)
        {
            ValueListItemAll response = new ValueListItemAll();


            response = await mediator.Send(new ReadByVLNameCommand
            {
                vlName = vlName
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateValueListItem createValueListItem)
        {
            ValueListItemDTO response = new ValueListItemDTO 
            ();
            response = await mediator.Send(new CreateValueListItemCommand
            {
                createValueListItem = createValueListItem
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateValueListItem updateValueListItem)
        {
            ValueListItemDTO response = new ValueListItemDTO();
            response = await mediator.Send(new UpdateValueListItemCommand
            {
                updateValueListItem = updateValueListItem
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
