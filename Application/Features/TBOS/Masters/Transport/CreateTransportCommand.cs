using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Transport;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Transport
{
    public class CreateTransportCommand : IRequest<TransportMasterDTO>
    {
        public CreateTransport createTransport { get; set; }
    }

    internal class CreateTransportCommandHandler : IRequestHandler<CreateTransportCommand, TransportMasterDTO>
    {
        protected readonly ITransportMaster _transportMasterService;
        public CreateTransportCommandHandler(ITransportMaster transportMasterService)
        {
            _transportMasterService = transportMasterService;
        }

        public async Task<TransportMasterDTO> Handle(CreateTransportCommand request, CancellationToken cancellationToken)
        {
            return await _transportMasterService.Create(request.createTransport);
        }
    }
}
