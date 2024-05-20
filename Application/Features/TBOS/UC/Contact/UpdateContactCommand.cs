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
    public class UpdateContactCommand : IRequest<ContactDetailDTO>
    {
        public UpdateContact updateContact { get; set; }
    }

    internal class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, ContactDetailDTO>
    {
        protected readonly IContactDetails _contactDetails;
        public UpdateContactCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactDetailDTO> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.Update(request.updateContact);
        }
    }
}
