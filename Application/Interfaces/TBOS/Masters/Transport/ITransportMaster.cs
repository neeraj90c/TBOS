using Application.DTOs.TBOS.Masters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Masters.Transport
{
    public interface ITransportMaster
    {
        public Task<TransportList> ReadAll();
        public Task<TransportMasterDTO> Create(CreateTransport createTransport);
        public Task<TransportMasterDTO> Update(UpdateTransport updateTransport);
        public Task<TransportMasterDTO> ReadById(int TransportId);
        public Task<Unit> Delete(DeleteTransport deleteTransport);

    }
}
