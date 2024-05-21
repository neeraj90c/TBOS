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
    public class ReadAllAddressCommand : IRequest<AddressList>
    {
    }

    internal class ReadAllAddressCommandHandler : IRequestHandler<ReadAllAddressCommand, AddressList>
    {
        protected readonly IAddressDetails _AddressDetails;
        public ReadAllAddressCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressList> Handle(ReadAllAddressCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.ReadAll();
        }
    }
}
