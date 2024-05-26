using Application.DTOs.TBOS.Ref.ValueList;
using Application.Interfaces.TBOS.Ref.ValueListItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Ref.ValueListItem
{
    public class ReadByValueListIdCommand : IRequest<ValueListItemAll>
    {
        public int ValuesListId { get; set; }
    }
    internal class ReadByValueListIdCommandHandler : IRequestHandler<ReadByValueListIdCommand,ValueListItemAll> 
    {
        protected readonly IValueListItem _valueListItem;
        public ReadByValueListIdCommandHandler(IValueListItem valueListItem)
        {
            _valueListItem = valueListItem;
        }

        public async Task<ValueListItemAll> Handle(ReadByValueListIdCommand request, CancellationToken cancellationToken)
        {
            return await _valueListItem.ReadByValueListId(request.ValuesListId);
        }
    }
}
