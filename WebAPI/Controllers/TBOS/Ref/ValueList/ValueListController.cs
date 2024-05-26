using Application;
using Domain.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Application.Features.TBOS.Ref.ValueList;
using Application.DTOs.TBOS.Ref.ValueList;

namespace WebAPI.Controllers.TBOS.Ref.ValueList
{
    [Route("TBOS/ValueList")]
    public class ValueListController : BaseApiController
    {
        APISettings _settings;
        public ValueListController(IOptions<APISettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet("ReadAll")]
        public async Task<IActionResult> ReadAll()
        {
            ValueListAll response = new ValueListAll();


            response = await mediator.Send(new ReadAllValueListCommand { });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateValueList createValueList)
        {
            ValueListDTO response = new ValueListDTO();
            response = await mediator.Send(new CreateValueListCommand
            {
                createValueList = createValueList
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateValueList updateValueList)
        {
            ValueListDTO response = new ValueListDTO();
            response = await mediator.Send(new UpdateValueListCommand
            {
                updateValueList = updateValueList
            });

            if (response == null)
                return Ok(APIResponse<string>.Unauthorized("Please check login credentials"));

            return Ok(response);
        }
    }
}
