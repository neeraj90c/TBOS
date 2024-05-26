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
    public class CreateValueListItemCommand: IRequest<ValueListItemDTO>
    {
        public CreateValueListItem createValueListItem { get; set; }
    }
    internal class CreateValueListItemCommandHandler : IRequestHandler<CreateValueListItemCommand, ValueListItemDTO>
    {
        protected readonly IValueListItem _valueListItem;
        public CreateValueListItemCommandHandler(IValueListItem valueListItem)
        {
            _valueListItem = valueListItem;
        }

        public async Task<ValueListItemDTO> Handle(CreateValueListItemCommand request, CancellationToken cancellationToken)
        {
            return await _valueListItem.Create(request.createValueListItem);
        }
    }
}
