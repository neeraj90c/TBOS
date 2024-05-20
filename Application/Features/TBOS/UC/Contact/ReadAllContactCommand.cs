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
    public class ReadAllContactCommand : IRequest<ContactList>
    {
    }

    internal class ReadAllContactCommandHandler : IRequestHandler<ReadAllContactCommand,ContactList> 
    {
        protected readonly IContactDetails _contactDetails;
        public ReadAllContactCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<ContactList> Handle(ReadAllContactCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.ReadAll();
        }
    }
}
