using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.UserControl
{
    public class ContactDetailDTO
    {
        public int ContactId { get; set; }
        public string MasterCode { get; set; }
        public string PersonName { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? ContactStatus { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class ContactList
    {
        public IEnumerable<ContactDetailDTO> Items { get; set; }
    }

    public class CreateContact
    {
        public string MasterCode { get; set; }
        public string PersonName { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? ContactStatus { get; set; }
        public string ActionUser { get; set; }
    }
    public class UpdateContact
    {
        public int ContactId { get; set; }
        public string MasterCode { get; set; }
        public string PersonName { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? ContactStatus { get; set; }
        public string ActionUser { get; set; }
    }
    public class DeleteContact
    {
        public int ContactId { get; set; }
        public string ActionUser { get; set; }
    }

}
