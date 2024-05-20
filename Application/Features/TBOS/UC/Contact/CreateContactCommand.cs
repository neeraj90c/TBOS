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
    public class CreateContactCommand : IRequest<ContactDetailDTO>
    {
        public CreateContact createContact {  get; set; }
    }
    internal class CreateContactCommandHandler : IRequestHandler<CreateContactCommand,ContactDetailDTO> 
    { 
        protected readonly IContactDetails _contactDetails;
        public CreateContactCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactDetailDTO> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.Create(request.createContact);
        }
    }
}
