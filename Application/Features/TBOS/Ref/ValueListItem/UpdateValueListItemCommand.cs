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
    public class UpdateValueListItemCommand : IRequest<ValueListItemDTO>
    {
        public UpdateValueListItem updateValueListItem { get; set; }
    }
    internal class UpdateValueListItemCommandHandler : IRequestHandler<UpdateValueListItemCommand,ValueListItemDTO> 
    {
        protected readonly IValueListItem _valueListItem;
        public UpdateValueListItemCommandHandler(IValueListItem valueListItem)
        {
            _valueListItem = valueListItem;
        }

        public async Task<ValueListItemDTO> Handle(UpdateValueListItemCommand request, CancellationToken cancellationToken)
        {
            return await _valueListItem.Update(request.updateValueListItem);
        }
    }
}
