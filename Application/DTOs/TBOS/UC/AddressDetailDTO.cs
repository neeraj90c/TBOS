using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.UserControl
{
    public class AddressDetailDTO
    {
        public int DetailId { get; set; }
        public string MasterCode { get; set; }
        public string AddressType { get; set; }
        public string add_line1 { get; set; }
        public string add_line2 { get; set; }
        public string add_line3 { get; set; }
        public string add_line4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public int? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class AddressList
    {
        public IEnumerable<AddressDetailDTO> Items { get; set; }
    }

    public class CreateAddress
    {
        public string MasterCode { get; set; }
        public string AddressType { get; set; }
        public string add_line1 { get; set; }
        public string add_line2 { get; set; }
        public string add_line3 { get; set; }
        public string add_line4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public int? Status { get; set; }
        public string ActionUser { get; set; }

    }
    public class UpdateAddress
    {
        public int DetailId { get; set; }
        public string MasterCode { get; set; }
        public string AddressType { get; set; }
        public string add_line1 { get; set; }
        public string add_line2 { get; set; }
        public string add_line3 { get; set; }
        public string add_line4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public int? Status { get; set; }
        public string ActionUser { get; set; }
    }
    public class DeleteAddress
    {
        public int DetailId { get; set; }
        public string ActionUser { get; set; }
    }
}
