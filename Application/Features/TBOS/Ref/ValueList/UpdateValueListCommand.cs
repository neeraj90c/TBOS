using Application.DTOs.TBOS.Ref.ValueList;
using Application.Interfaces.TBOS.Ref.ValueList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Ref.ValueList
{
    public class UpdateValueListCommand : IRequest<ValueListDTO>
    {
        public UpdateValueList updateValueList { get; set; }
    }
    internal class UpdateValueListCommandHandler : IRequestHandler<UpdateValueListCommand,ValueListDTO> 
    { 
        protected readonly IValueList _valueList;

        public UpdateValueListCommandHandler(IValueList valueList)
        {
            _valueList = valueList;
        }

        public async Task<ValueListDTO> Handle(UpdateValueListCommand request, CancellationToken cancellationToken)
        {
            return await _valueList.Update(request.updateValueList);
        }
    }
}
