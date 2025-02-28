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
    public class ReadByVLNameMultiCommand : IRequest<VlDictionaryList>
    {
        public MultiVLNameRequest multiVLNameRequest {  get; set; }
    }
    internal class ReadByVLNameMultiCommandHandler : IRequestHandler<ReadByVLNameMultiCommand,VlDictionaryList> 
    {
        protected readonly IValueListItem _valueListItem;
        public ReadByVLNameMultiCommandHandler(IValueListItem valueListItem)
        {
            _valueListItem = valueListItem;
        }

        public async Task<VlDictionaryList> Handle(ReadByVLNameMultiCommand request, CancellationToken cancellationToken)
        {
            return await _valueListItem.ReadByVLNameMulti(request.multiVLNameRequest);
        }
    }
}
