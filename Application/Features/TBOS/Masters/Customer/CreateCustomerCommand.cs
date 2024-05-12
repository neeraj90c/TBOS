using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Branch;
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
    public class CreateCustomerCommand : IRequest<CustomerMasterDTO>
    {
        public CreateCustomer createCustomer  { get; set; }
    }
    internal class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerMasterDTO>
    {
        protected readonly ICustomerMaster _customerMasterService;
        public CreateCustomerCommandHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerMasterDTO> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.Create(request.createCustomer);
        }
    }
}
