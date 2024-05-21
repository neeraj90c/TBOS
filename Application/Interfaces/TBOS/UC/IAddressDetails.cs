using Application.DTOs.TBOS.UserControl;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.UC
{
    public interface IAddressDetails
    {
        public Task<AddressList> ReadAll();
        public Task<AddressDetailDTO> Create(CreateAddress createAddress);
        public Task<AddressDetailDTO> Update(UpdateAddress updateAddress);
        public Task<AddressDetailDTO> ReadById(int AddressId);
        public Task<Unit> Delete(DeleteAddress deleteAddress);
        public Task<AddressList> ReadByMasterCode(string MasterCode);
        public Task<AddressDetailDTO> ReadByMasterCodeDefault(string MasterCode);
    }
}
