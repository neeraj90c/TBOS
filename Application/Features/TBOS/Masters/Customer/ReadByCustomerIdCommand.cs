using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Customer
{
    public class ReadByCustomerIdCommand : IRequest<CustomerMasterDTO>
    {
        public int CustomerId { get; set; }
    }

    internal class ReadByCustomerIdCommandHandler : IRequestHandler<ReadByCustomerIdCommand, CustomerMasterDTO>
    {
        protected readonly ICustomerMaster _customerMasterService;
        public ReadByCustomerIdCommandHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerMasterDTO> Handle(ReadByCustomerIdCommand request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.ReadByCustomerId(request.CustomerId);
        }
    }
}
