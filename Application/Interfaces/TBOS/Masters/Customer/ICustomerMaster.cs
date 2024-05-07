using Application.DTOs.TBOS.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Masters.Customer
{
    public interface ICustomerMaster
    {
        public Task<CustomerMasterDTO> Create(CreateCustomer createCustomer);
        public Task<CustomerMasterDTO> Update(UpdateCustomer updateCustomer);
        public Task<CustomerList> ReadAll();
        public Task<CustomerMasterDTO> ReadByCustomerId(int CustomerId);
        public Task<CustomerList> Delete(DeleteCustomer deleteCustomer);

    }
}
