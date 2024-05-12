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
    public class UpdateCustomerCommand : IRequest<CustomerMasterDTO>
    {
        public UpdateCustomer updateCustomer { get; set; }
    }
    internal class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, CustomerMasterDTO> 
    {
        protected readonly ICustomerMaster _customerMasterService;
        public UpdateCustomerCommandHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerMasterDTO> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.Update(request.updateCustomer);
        }
    }
}
