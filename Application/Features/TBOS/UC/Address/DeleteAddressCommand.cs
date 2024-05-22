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
    public class DeleteAddressCommand : IRequest<Unit>
    {
        public DeleteAddress deleteAddress { get; set; }
    }
    internal class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, Unit>
    {
        protected readonly IAddressDetails _AddressDetails;
        public DeleteAddressCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.Delete(request.deleteAddress);
        }
    }
}
