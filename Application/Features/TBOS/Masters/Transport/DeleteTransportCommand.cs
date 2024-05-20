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
    public class DeleteTransportCommand : IRequest<Unit>
    {
        public DeleteTransport deleteTransport { get; set; }
    }
    internal class DeleteTransportCommandHandler : IRequestHandler<DeleteTransportCommand,Unit>
    {
        protected readonly ITransportMaster _transportMasterService;
        public DeleteTransportCommandHandler(ITransportMaster transportMasterService)
        {
            _transportMasterService = transportMasterService;
        }

        public async Task<Unit> Handle(DeleteTransportCommand request, CancellationToken cancellationToken)
        {
           
            return await _transportMasterService.Delete(request.deleteTransport);

        }
    }
}
