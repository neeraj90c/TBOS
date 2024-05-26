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
    public class CreateValueListCommand : IRequest<ValueListDTO>
    {
        public CreateValueList createValueList { get; set; }
    }

    internal class CreateValueListCommandHandler : IRequestHandler<CreateValueListCommand, ValueListDTO>
    {
        protected readonly IValueList _valueList;
        public CreateValueListCommandHandler(IValueList valueList)
        {
            _valueList = valueList;
        }

        public async Task<ValueListDTO> Handle(CreateValueListCommand request, CancellationToken cancellationToken)
        {
            return await _valueList.Create(request.createValueList);
        }
    }
}
