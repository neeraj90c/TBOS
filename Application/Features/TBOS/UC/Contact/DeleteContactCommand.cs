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
    public class DeleteContactCommand : IRequest<Unit>
    {
        public DeleteContact deleteContact { get; set; }
    }
    internal class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, Unit>
    {
        protected readonly IContactDetails _contactDetails;
        public DeleteContactCommandHandler(IContactDetails contactDetails)
        {
            _contactDetails = contactDetails;
        }

        public async Task<Unit> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            return await _contactDetails.Delete(request.deleteContact);
        }
    }
}
