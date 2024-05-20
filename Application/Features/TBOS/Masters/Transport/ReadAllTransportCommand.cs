using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Customer;
using Application.Interfaces.TBOS.Masters.Transport;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Transport
{
    public class ReadAllTransportCommand : IRequest<TransportList>
    {
    }
    internal class ReadAllTransportCommandHandler : IRequestHandler<ReadAllTransportCommand, TransportList>
    {
        protected readonly ITransportMaster _transportMasterService;
        public ReadAllTransportCommandHandler(ITransportMaster transportMasterService) 
        {
            _transportMasterService = transportMasterService;
        }
        public async Task<TransportList> Handle(ReadAllTransportCommand request, CancellationToken cancellationToken)
        {
           return await _transportMasterService.ReadAll();
        }
    }
}
