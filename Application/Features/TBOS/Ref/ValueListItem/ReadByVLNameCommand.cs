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
    public class ReadByVLNameCommand : IRequest<ValueListItemAll>
    {
        public string vlName { get; set; }
    }
    internal class ReadByVLNameCommandHandler : IRequestHandler<ReadByVLNameCommand,ValueListItemAll>
    {
        protected readonly IValueListItem _valueListItem;
        public ReadByVLNameCommandHandler(IValueListItem valueListItem)
        {
            _valueListItem = valueListItem;
        }

        public async Task<ValueListItemAll> Handle(ReadByVLNameCommand request, CancellationToken cancellationToken)
        {
            return await _valueListItem.ReadByVLName(request.vlName);
        }
    }
}
