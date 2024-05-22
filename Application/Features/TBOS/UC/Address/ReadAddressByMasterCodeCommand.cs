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
    public class ReadAddressByMasterCodeCommand : IRequest<AddressList>
    {
        public string MasterCode { get; set; }
    }

    internal class ReadAddressByMasterCodeCommandHandler : IRequestHandler<ReadAddressByMasterCodeCommand, AddressList>
    {
        protected readonly IAddressDetails _AddressDetails;
        public ReadAddressByMasterCodeCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressList> Handle(ReadAddressByMasterCodeCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.ReadByMasterCode(request.MasterCode);
        }
    }
}
