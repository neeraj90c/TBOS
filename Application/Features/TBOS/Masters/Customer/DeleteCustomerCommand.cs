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
    public class DeleteCustomerCommand : IRequest<CustomerList>
    {
        public DeleteCustomer deleteCustomer {  get; set; }
    }

    internal class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, CustomerList>
    {
        protected readonly ICustomerMaster _customerMasterService;
        public DeleteCustomerCommandHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerList> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.Delete(request.deleteCustomer);
        }
    }
}
