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
    public class ReadAllValueListCommand : IRequest<ValueListAll>
    {
    }
    internal class ReadAllValueListCommandHandler : IRequestHandler<ReadAllValueListCommand,ValueListAll>
    {
        protected readonly IValueList _valueList;

        public ReadAllValueListCommandHandler(IValueList valueList)
        {
            _valueList = valueList;
        }

        public async Task<ValueListAll> Handle(ReadAllValueListCommand request, CancellationToken cancellationToken)
        {
            return await _valueList.ReadAll();
        }
    }
}
