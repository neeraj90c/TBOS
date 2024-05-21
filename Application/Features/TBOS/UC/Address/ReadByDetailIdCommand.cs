using Application.DTOs.TBOS.UserControl;
using Application.Interfaces.TBOS.UC;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.UC.Address
{
    public class ReadByDetailIdCommand : IRequest<AddressDetailDTO>
    {
        public int DetailId { get; set; }
    }
    internal class ReadByDetailIdCommandHandler : IRequestHandler<ReadByDetailIdCommand, AddressDetailDTO>
    {
        protected readonly IAddressDetails _AddressDetails;
        public ReadByDetailIdCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressDetailDTO> Handle(ReadByDetailIdCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.ReadById(request.DetailId);
        }
    }
}
