using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Masters
{
    public class TransportMasterDTO
    {
        public int TransportId { get; set; }
        public string TransportName { get; set; }
        public string BranchCode { get; set; }
        public string Specialization { get; set; }
        public int? TransportStatus { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class TransportList
    {
        public IEnumerable<TransportMasterDTO> Items { get; set; }
    }

    public class CreateTransport
    {
        public string TransportName { get; set; }
        public string BranchCode { get; set; }
        public string Specialization { get; set; }
        public int TransportStatus { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ActionUser { get; set; }
    }
    public class UpdateTransport
    {
        public int TransportId { get; set; }
        public string TransportName { get; set; }
        public string BranchCode { get; set; }
        public string Specialization { get; set; }
        public int TransportStatus { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ActionUser { get; set; }
    }

    public class DeleteTransport
    {
        public int TransportId { get; set; }
        public string ActionUser { get; set; }
    }
}
