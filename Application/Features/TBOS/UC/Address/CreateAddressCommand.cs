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
    public class CreateAddressCommand : IRequest<AddressDetailDTO>
    {
        public CreateAddress createAddress { get; set; }
    }
    internal class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, AddressDetailDTO>
    {
        protected readonly IAddressDetails _AddressDetails;
        public CreateAddressCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressDetailDTO> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.Create(request.createAddress);
        }
    }
}
