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
    public class ReadByContactIdCommand : IRequest<ContactDetailDTO>
    {
        public int ContactId { get; set; }
    }
    internal class ReadByContactIdCommandHandler : IRequestHandler<ReadByContactIdCommand, ContactDetailDTO>
    {
        protected readonly IContactDetails _contactDetails;
        public ReadByContactIdCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactDetailDTO> Handle(ReadByContactIdCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.ReadById(request.ContactId);
        }
    }
}
