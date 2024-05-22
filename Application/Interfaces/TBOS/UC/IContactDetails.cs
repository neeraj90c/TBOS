using Application.DTOs.TBOS.Masters;
using Application.DTOs.TBOS.UserControl;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.UC
{
    public interface IContactDetails
    {
        public Task<ContactList> ReadAll();
        public Task<ContactDetailDTO> Create(CreateContact createContact);
        public Task<ContactDetailDTO> Update(UpdateContact updateContact);
        public Task<ContactDetailDTO> ReadById(int ContactId);
        public Task<Unit> Delete(DeleteContact deleteContact);
        public Task<ContactList> ReadByMasterCode(string MasterCode);
        public Task<ContactDetailDTO> ReadByMasterCodeDefault(string MasterCode);
    }
}
