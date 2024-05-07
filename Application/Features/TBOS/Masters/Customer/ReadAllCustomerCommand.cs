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
    public class ReadAllCustomerCommand : IRequest<CustomerList> { }

    internal class ReadAllCustomerCommandHandler : IRequestHandler<ReadAllCustomerCommand, CustomerList>
    {
        protected readonly ICustomerMaster _customerMasterService;
        public ReadAllCustomerCommandHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerList> Handle(ReadAllCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.ReadAll();
        }

    }
}
