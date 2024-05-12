using Application.DTOs.TBOS.Common;
using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.TBOS.Masters.Customer
{
    public  class ReadAllCustomerPaginated : IRequest<CustomerListPaginated>
    {
        public PaginatedDTO paginatedDTO { get; set; }
    }

    internal class ReadAllCustomerPaginatedHandler : IRequestHandler<ReadAllCustomerPaginated, CustomerListPaginated>
    {
        protected readonly ICustomerMaster _customerMasterService;

        public ReadAllCustomerPaginatedHandler(ICustomerMaster customerMasterService)
        {
            _customerMasterService = customerMasterService;
        }

        public async Task<CustomerListPaginated> Handle(ReadAllCustomerPaginated request, CancellationToken cancellationToken)
        {
            return await _customerMasterService.ReadAllPaginated(request.paginatedDTO);
        }
    }
}
