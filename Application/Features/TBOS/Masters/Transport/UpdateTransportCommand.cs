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
    public class UpdateTransportCommand : IRequest<TransportMasterDTO>
    {
        public UpdateTransport updateTransport { get; set; }
    }
    internal class UpdateTransportCommandHandler : IRequestHandler<UpdateTransportCommand,TransportMasterDTO>
    {
        protected readonly ITransportMaster _transportMasterService;
        public UpdateTransportCommandHandler(ITransportMaster transportMasterService)
        {
            _transportMasterService = transportMasterService;
        }

        public async Task<TransportMasterDTO> Handle(UpdateTransportCommand request, CancellationToken cancellationToken)
        {
            return await _transportMasterService.Update(request.updateTransport);
        }
    }
}
