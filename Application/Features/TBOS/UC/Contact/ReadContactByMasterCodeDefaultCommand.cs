using Application.DTOs.TBOS.UserControl;
using Application.Interfaces.TBOS.UC;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.UC.Contact
{
    public class ReadContactByMasterCodeDefaultCommand : IRequest<ContactDetailDTO>
    {
        public string MasterCode { get; set; }
    }
    internal class ReadContactByMasterCodeDefaultCommandHandler : IRequestHandler<ReadContactByMasterCodeDefaultCommand,ContactDetailDTO> 
    { 
        protected readonly IContactDetails _contactDetails;
    
        public ReadContactByMasterCodeDefaultCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactDetailDTO> Handle(ReadContactByMasterCodeDefaultCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.ReadByMasterCodeDefault(request.MasterCode);
        }
    }
}
