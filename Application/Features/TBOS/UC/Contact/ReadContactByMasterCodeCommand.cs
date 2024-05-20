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
    public class ReadContactByMasterCodeCommand : IRequest<ContactList>
    {
        public string MasterCode { get; set; }
    }

    internal class ReadContactByMasterCodeCommandHandler : IRequestHandler<ReadContactByMasterCodeCommand, ContactList>
    {
        protected readonly IContactDetails _contactDetails;
        public ReadContactByMasterCodeCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactList> Handle(ReadContactByMasterCodeCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.ReadByMasterCode(request.MasterCode);
        }
    }
}
