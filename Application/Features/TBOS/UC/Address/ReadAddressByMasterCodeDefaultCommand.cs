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
    public class ReadAddressByMasterCodeDefaultCommand : IRequest<AddressDetailDTO>
    {
        public string MasterCode { get; set; }
    }
    internal class ReadAddressByMasterCodeDefaultCommandHandler : IRequestHandler<ReadAddressByMasterCodeDefaultCommand, AddressDetailDTO>
    {
        protected readonly IAddressDetails _AddressDetails;

        public ReadAddressByMasterCodeDefaultCommandHandler(IAddressDetails AddressDetails)
        {
            _AddressDetails = AddressDetails;
        }

        public async Task<AddressDetailDTO> Handle(ReadAddressByMasterCodeDefaultCommand request, CancellationToken cancellationToken)
        {
            return await _AddressDetails.ReadByMasterCodeDefault(request.MasterCode);
        }
    }
}
