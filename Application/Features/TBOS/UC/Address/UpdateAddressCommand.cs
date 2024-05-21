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
    public class UpdateAddressCommand : IRequest<AddressDetailDTO>
    {
        public UpdateAddress updateAddress { get; set; }
    }

    internal class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, AddressDetailDTO>
    {
        protected readonly IAddressDetails _AddressDetails;
        public UpdateAddressCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressDetailDTO> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.Update(request.updateAddress);
        }
    }
}
