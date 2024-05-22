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
    public class ReadByTransportIdCommand : IRequest<TransportMasterDTO>
    {
        public int TransportId { get; set; }
    }

    internal class ReadByTransportIdCommandHandler : IRequestHandler<ReadByTransportIdCommand,TransportMasterDTO>
    {
        protected readonly ITransportMaster _transportMasterService;
        public ReadByTransportIdCommandHandler(ITransportMaster transportMasterService)
        {
            _transportMasterService = transportMasterService;
        }

        public async Task<TransportMasterDTO> Handle(ReadByTransportIdCommand request, CancellationToken cancellationToken)
        {
            return await _transportMasterService.ReadById(request.TransportId);
        }
    }
}
